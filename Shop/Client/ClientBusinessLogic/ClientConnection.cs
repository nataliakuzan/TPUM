using ClientData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace ClientBusinessLogic
{
    public class ClientConnection : IClientConnection
    {
        public bool Connected
        {
            get
            {
                if (WebSocketClient.CurrentConnection != null)
                {
                    return WebSocketClient.CurrentConnection.IsConnected;
                }

                return false;
            }
        }

        public async Task<bool> Connect(Uri peerUri)
        {
            List<string> logOutput = new List<string>();
            try
            {
                await WebSocketClient.Connect(peerUri, message => logOutput.Add(message));

                return await Task.FromResult(true);
            }
            catch (WebSocketException e)
            {
                Debug.WriteLine($"Caught web socket exception {e.Message}");
                logOutput.Add(e.Message);
                return await Task.FromResult(false);
            }
        }

        public async Task Disconnect()
        {
            await WebSocketClient.Disconnect();
        }

        public async Task SendAsync(string message)
        {
            await WebSocketClient.CurrentConnection.SendAsync(message);
        }

        public void SetMessageHandler(Action<string> MessageHandler)
        {
            if (Connected)
            {
                WebSocketClient.CurrentConnection.onMessage = MessageHandler;
            }
        }
    }
}
