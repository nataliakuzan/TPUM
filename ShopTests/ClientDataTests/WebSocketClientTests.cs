using ClientData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerPresentation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientDataTests
{
    [TestClass]
    public class WebSocketClientTests
    {
        [TestMethod]
        public async Task WebSocketUsageTestMethod()
        {
            ServerPresentation.WebSocketConnection _wserver = null;
            ClientData.WebSocketConnection _wclient = null;
            const int _delay = 10;

            Uri uri = new Uri("ws://localhost:6966");
            List<string> logOutput = new List<string>();
            Task server = Task.Run(async () => await WebSocketServer.Server(uri.Port,
                _ws =>
                {
                    _wserver = _ws; _wserver.onMessage = (data) =>
                    {
                        logOutput.Add($"Received message from client: { data}");
                    };
                }));
            await Task.Delay(_delay);

            _wclient = await WebSocketClient.Connect(uri, message => logOutput.Add(message));

            Assert.IsNotNull(_wserver);
            Assert.IsNotNull(_wclient);

            Task clientSendTask = _wclient.SendAsync("test");
            Assert.IsTrue(clientSendTask.Wait(new TimeSpan(0, 0, 1)));
            await Task.Delay(_delay);

            Assert.AreEqual($"Received message from client: test", logOutput[1]);

            _wclient.onMessage = (data) =>
            {
                logOutput.Add($"Received message from server: { data}");
            };
            Task serverSendTask = _wserver.SendAsync("test 2");
            Assert.IsTrue(serverSendTask.Wait(new TimeSpan(0, 0, 1)));
            await Task.Delay(_delay);
            Assert.AreEqual($"Received message from server: test 2", logOutput[2]);
            await _wclient?.DisconnectAsync();
            await _wserver?.DisconnectAsync();
        }
    }
}
