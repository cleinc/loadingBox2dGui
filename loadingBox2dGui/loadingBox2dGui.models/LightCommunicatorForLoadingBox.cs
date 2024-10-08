using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public abstract class LightCommunicatorForLoadingBox : ILightCommunicator, IDisposable
    {
        public abstract event EventHandler LightSent;
        public abstract event EventHandler LightReceived;
        public abstract event EventHandler LightConnected;
        public abstract event EventHandler LightDisconnected;

        private bool _disposedValue;
        protected CancellationTokenSource _cts = new CancellationTokenSource();

        public abstract bool IsConnected { get; set; }
        public abstract bool Connect(int timeout);
        public abstract bool Disconnect();
        public abstract bool WriteLightState(bool state);
        public abstract bool ReadLightState();
        public abstract bool LightState { get; set; }

        public Task<bool> ConnectAsync(int timeout)
        {
            CancellationToken token = _cts.Token;
            return Task.Run(() => Connect(timeout), token);
        }

        public Task<bool> DisconnectAsync()
        {
            return Task.Run(() => Disconnect());
        }


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
                }

                // TODO: 비관리형 리소스(비관리형 개체)를 해제하고 종료자를 재정의합니다.
                // TODO: 큰 필드를 null로 설정합니다.
                _disposedValue = true;
            }
        }

        // TODO: 비관리형 리소스를 해제하는 코드가 'Dispose(bool disposing)'에 포함된 경우에만 종료자를 재정의합니다.
        ~LightCommunicatorForLoadingBox()
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
}
