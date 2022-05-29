using ClientBusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerPresentation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientBusinessLogicTests
{
    [TestClass]
    public class ClientConnectionTests
    {
        [TestMethod]
        public async Task ClientConnectionTestMethodAsync()
        {
            IClientConnection clientConnection = new ClientConnection();

            Assert.AreEqual(false, clientConnection.Connected);

            Uri uri = new Uri("ws://localhost:6999");
            List<string> logOutput = new List<string>();
            WebSocketConnection _wserver = null;
            Task server = Task.Run(async () => await WebSocketServer.Server(uri.Port,
                _ws =>
                {
                    _wserver = _ws; _wserver.onMessage = (data) =>
                    {
                        logOutput.Add($"Received message from client: { data}");
                    };
                }));
            if (!clientConnection.Connected)
            {
                bool result = await clientConnection.Connect(uri);
                if (result)
                {
                    Task clientSendTask = clientConnection.SendAsync("test");
                    Assert.IsTrue(clientSendTask.Wait(new TimeSpan(0, 0, 1)));
                }
            }
        }
    }
}
