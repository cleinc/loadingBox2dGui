using System;
using CoPick.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using loadingBox2dGui.models;
using Modbus.Device;

namespace loadingBox2dGui.ModbusLightCommunicator
{
    public class ModbusLightCommunicator : LightCommunicatorForLoadingBox, IDisposable
    {
        protected static readonly LogHelper Logger = LogHelper.Logger;

        private bool _isConnected;
        private bool _lightState;
        private TcpClient _tcpClient { get; set; } = new TcpClient();
        private ModbusIpMaster _master { get; set; }
        public string IpAddr { get; set; } = "192.168.2.3";
        public int Port { get; set; } = 502;
        private ushort _stateRegister = 2000;
        private object _lock = new object();

        public override event EventHandler LightSent;
        public override event EventHandler LightReceived;
        public override event EventHandler LightConnected;
        public override event EventHandler LightDisconnected;

        public override bool IsConnected
        {
            get
            {
                _isConnected = IsTcpConnected(_tcpClient);
                return _isConnected;
            }
            set => _isConnected = value;
        }

        public override bool LightState
        {
            get => _lightState;
            set => _lightState = value;
        }

        public bool IsTcpConnected(TcpClient tcpClient)
        {
            try
            {
                if (tcpClient != null && tcpClient.Client != null && tcpClient.Client.Connected)
                {
                    // Poll (0, SelectMode.SelectRead) returns
                    // - true if the connection is closed, reset, terminated, or pending
                    // - false otherwise
                    if (tcpClient.Client.Poll(0, SelectMode.SelectRead))
                    {
                        byte[] buffer = new byte[1];
                        if (tcpClient.Client.Receive(buffer, SocketFlags.Peek) == 0)
                        {
                            // Connection is closed
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SocketException ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
        }

        public override bool Connect(int timeout = 1000)
        {
            lock (_lock)
            {
                try
                {
                    if (IsConnected)
                    {
                        return true;
                    }
                    _tcpClient = new TcpClient();
                    _tcpClient.Connect(IpAddr, Port);
                    _master = ModbusIpMaster.CreateIp(_tcpClient);
                    IsConnected = true;

                    Task.Run(() =>
                    {
                        LightConnected?.Invoke(this, null);
                    });
                }
                catch (Exception ex)
                {
                    Logger.Warning($"Modbus Light Connection Failed. {ex.Message}, {IpAddr}");
                    IsConnected = false;
                    return false;
                }
                return true;
            }
        }

        public override bool Disconnect()
        {
            if (_tcpClient != null)
            {
                try
                {
                    if (LightState == true)
                    {
                        WriteLightState(false);
                    }
                    // TcpClient의 내부 Socket 객체 닫기
                    if (_tcpClient.Client != null)
                    {
                        _tcpClient.Client.Shutdown(SocketShutdown.Both);
                        _tcpClient.Client.Close();
                    }

                    Task.Run(() =>
                    {
                        LightDisconnected?.Invoke(this, null);
                    });
                    return true;
                }
                catch (SocketException ex)
                {
                    Console.WriteLine($"Socket Exception Occurred : {ex.Message}");
                    return false;
                }
                finally
                {
                    // TcpClient 리소스 해제
                    _tcpClient.Close();
                }
            }
            return false;
        }

        public override bool WriteLightState(bool state)
        {
            try
            {
                if (Connect())
                {
                    if (state == true)
                    {
                        _master.WriteSingleRegister(_stateRegister, 0x0100);
                    }
                    else
                    {
                        _master.WriteSingleRegister(_stateRegister, 0x0000);
                    }
                    _lightState = state;
                    Task.Run(() =>
                    {
                        LightSent?.Invoke(this, null);
                    });
                    return true;
                }
                else
                {
                    Logger.Warning("Disconnected. Failed to Write light state: " + state);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("ERROR OCCURRED WHILE WRITING SIGNAL : " + ex.Message);
                return false;
            }
        }

        public override bool ReadLightState()
        {
            try
            {
                if (Connect())
                {
                    ushort[] result;
                    result = _master.ReadHoldingRegisters(_stateRegister, 1);

                    if (result != null && result.Length == 1)
                    {
                        if(result[0] == 0x0100)
                        {
                            _lightState = true;
                        }
                        else
                        {
                            _lightState = false;
                        }

                        Task.Run(() =>
                        {
                            LightReceived?.Invoke(this, null);
                        });
                        return _lightState;
                    }
                    else
                    {
                        Logger.Error("Reading Light state Failed : " + _stateRegister);
                        return false;
                    }

                }
                else
                {
                    Logger.Warning("Disconnected. Failed to Read light state : " + _stateRegister);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("ERROR OCCURRED WHILE READING SIGNAL : " + ex.Message);
                return false;
            }
        }

        public ModbusLightCommunicator()
        {
            WriteLightState(false);
        }
    }
}
