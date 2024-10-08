using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public interface ILightCommunicator : IDisposable
    {
        event EventHandler LightSent;
        event EventHandler LightReceived;
        event EventHandler LightConnected;
        event EventHandler LightDisconnected;

        bool Connect(int timeout);
        bool Disconnect();
        Task<bool> ConnectAsync(int timeout);
        Task<bool> DisconnectAsync();
        bool WriteLightState(bool state);
        bool ReadLightState();
    }
}
