﻿using ClientData;
using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace ClientBusinessLogic
{
    public class ClientConnection : IClientConnection
    {
        public Action<string> ConnectionLogger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            try
            {
                ConnectionLogger?.Invoke($"Establishing connection to {peerUri.OriginalString}");

                await WebSocketClient.Connect(peerUri, ConnectionLogger);

                return await Task.FromResult(true);
            }
            catch (WebSocketException e)
            {
                Debug.WriteLine($"Caught web socket exception {e.Message}");
                ConnectionLogger?.Invoke(e.Message);
                return await Task.FromResult(false);
            }
        }

        public async Task Disconnect()
        {
            await WebSocketClient.Disconnect();
        }
    }
}
