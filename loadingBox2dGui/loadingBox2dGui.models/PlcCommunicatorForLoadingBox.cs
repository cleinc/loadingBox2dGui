using CoPick.Plc;
using CoPick.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace loadingBox2dGui.models
{
    public abstract class PlcCommunicatorForLoadingBox : IPlcCommunicator, IDisposable
    {
        protected static readonly LogHelper Logger = LogHelper.Logger;

        public abstract event EventHandler<VisionUpdateEventArgs> CarTypeUpdate;
        public abstract event EventHandler VisionStart;
        public abstract event EventHandler VisionReset;
        public abstract event EventHandler VisionEnd;
        public abstract event EventHandler PlcSent;
        public abstract event EventHandler PlcReceived;
        public abstract event EventHandler PlcConnected;
        public abstract event EventHandler PlcDisconnected;
        public abstract event EventHandler PlcError;

        private bool _disposedValue;

        public abstract bool IsConnected { get; set; }
        public abstract bool IsConnecting { get; set; }

        public int CarType { get; set; }
        public string CarSeq { get; set; }
        public string BodyNumber { get; set; }
        public bool VisionPass { get; set; }
        public List<PlcMonitorInfo<PlcSignalForLoadingBox>> PlcMonitorInfos { get; set; }
        public List<S7MonitorDbInfo<PlcSignalForLoadingBox>> MonitorDbInfoList { get; set; }

        //public List<PlcMonitorInfo<PlcSignalForSealer>> PlcDataInfos { get; set; }

        protected Thread _monitorPlcThread;
        protected ManualResetEvent _plcMonitorStartEvent = new ManualResetEvent(false);
        protected ManualResetEvent _plcMonitorBlockEvent = new ManualResetEvent(false);
        protected AutoResetEvent _plcMonitorStopEvent = new AutoResetEvent(false);

        protected object _lockObj = new object();
        protected CancellationTokenSource _cts = new CancellationTokenSource();
        protected Queue<CancellationTokenSource> _ctsQueue = new Queue<CancellationTokenSource>();

        protected int _maxNumberOfConnectionTries = int.MaxValue;
        protected int _delayBetweenConnectionTries = 1500;

        private uint _count = 0;
        protected bool _onPlcLoop = false;
        protected PlcCommunicatorForLoadingBox(int timeoutMs)
        {
            _monitorPlcThread = new Thread(() => MonitorPlcLoop(timeoutMs));
            _monitorPlcThread.Start();
        }

        public abstract void Connect(CancellationToken? cancelToken = null);
        public abstract void Disconnect();
        public abstract void SendHeartbeat();
        public abstract Task SendHeartbeatAsync();
        public abstract void MonitorPlc();
        public abstract void RaiseEventIfItNeeds();
        public abstract Task<int> SendLocalizerStatusAsync(PlcSignalForLoadingBox status, bool val, int nMaxTrials, int delay);

        public Task<bool> ConnectAsync()
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            return Task.Run(() =>
            {
                if (IsConnecting || IsConnected)
                {
                    return true;
                }
                IsConnecting = true;

                for (int i = 0; i < _maxNumberOfConnectionTries; ++i)
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }

                    Logger.Info($"Lang.MSGPlc.ConnectingPlc Trial : ({i + 1})");
                    Connect();
                    if (IsConnected)
                    {
                        Logger.Info("Lang.MSGPlc.ConnectingPlcSucceed");
                        break;
                    }

                    Thread.Sleep(_delayBetweenConnectionTries);
                }

                IsConnecting = false;
                return IsConnected;
            }, token);
        }

        public Task<bool> DisconnectAsync()
        {
            return Task.Run(() =>
            {
                if (IsConnecting)
                {
                    _cts.Cancel();

                    while (IsConnecting)
                    {
                        Thread.Sleep(100);
                    }
                }

                if (IsConnected)
                {
                    Disconnect();
                }

                return !IsConnected;
            });
        }


        public abstract void StartMonitoringPlc();
        public abstract void StopMonitoringPlc();
        public abstract void PauseMonitoringPlc();

        public void StartMonitoring(int interval)
        {
            throw new NotImplementedException();
        }

        public void StopMonitoring()
        {
            throw new NotImplementedException();
        }

        public void StartHeartbeat(int interval)
        {
            throw new NotImplementedException();
        }

        public void StopHeartbeat()
        {
            throw new NotImplementedException();
        }
        protected void MonitorPlcLoop(int timeout)
        {
            while (true)
            {
                _plcMonitorBlockEvent.Reset();
                _plcMonitorStartEvent.WaitOne();

                if (_plcMonitorStopEvent.WaitOne(3))
                {
                    break;
                }

                if (IsConnected)
                {
                    _onPlcLoop = true;
                    try
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        if (_count == 3)
                        {
                            SendHeartbeat();
                            _count = 0;
                        }
                        _count++;

                        MonitorPlc();

                        stopwatch.Stop();
                        if (stopwatch.ElapsedMilliseconds > 200)
                        {
                            Logger.Debug($"Lang.MSGPlc.MonitorPlcLoopDelayOccured {stopwatch.ElapsedMilliseconds} ms");
                        }

                        RaiseEventIfItNeeds();
                    }
                    catch (Exception ex)
                    {
                        Logger.Error($"Lang.MSGPlc.MonitorPlcLoopErrorOccurred {ex}");
                    }
                }

                _plcMonitorBlockEvent.Set();
                _onPlcLoop = false;
                Thread.Sleep(timeout);
            }
        }

        #region obsolete
        bool IPlcCommunicator.Connect(CancellationToken? cancelToken)
        {
            throw new NotImplementedException();
        }

        bool IPlcCommunicator.Disconnect()
        {
            throw new NotImplementedException();
        }
        #endregion

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: 관리형 상태(관리형 개체)를 삭제합니다.
                    if (IsConnected)
                    {
                        Disconnect();
                    }
                    StopMonitoringPlc();
                }

                // TODO: 비관리형 리소스(비관리형 개체)를 해제하고 종료자를 재정의합니다.
                // TODO: 큰 필드를 null로 설정합니다.
                _disposedValue = true;
            }
        }

        // TODO: 비관리형 리소스를 해제하는 코드가 'Dispose(bool disposing)'에 포함된 경우에만 종료자를 재정의합니다.
        ~PlcCommunicatorForLoadingBox()
        {
            // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public class VisionUpdateEventArgs : EventArgs
    {
        public int CarType { get; private set; }
        public string CarSeq { get; private set; }
        public string BodyNumber { get; private set; }

        public VisionUpdateEventArgs(int carType, string carSeq)
        {
            CarType = carType;
            CarSeq = carSeq;
        }

        public VisionUpdateEventArgs(int carType, string carSeq, string bodyNumber)
            : this(carType, carSeq)
        {
            BodyNumber = bodyNumber;
        }
    }
}
