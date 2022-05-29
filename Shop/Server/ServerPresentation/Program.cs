using Shop.ServerBusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerPresentation
{
    class Program
    {
        public static IBusinessLogicLayer LogicLayer;

        static async Task Main(string[] args)
        {
            LogicLayer = new BusinessLogicLayer();
            LogicLayer.Shop.Initialize();
            Console.WriteLine("Server started");
            await WebSocketServer.Server(8081, ConnectionHandler);
        }

        static void ConnectionHandler(WebSocketConnection webSocketConnection)
        {
            Console.WriteLine("[Server]: Client connected");
            WebSocketServer.CurrentConnection = webSocketConnection;
            webSocketConnection.onMessage = MessageHandler;
            webSocketConnection.onClose = () => { Console.WriteLine("[Server]: Connection closed"); };
            webSocketConnection.onError = () => { Console.WriteLine("[Server]: Connection error encountered"); };
        }

        static async void MessageHandler(string message)
        {
            Console.WriteLine($"[Client]: {message}");

            CommandExecuter CommandExecuter = new CommandExecuter();

            await SendMessageAsync(CommandExecuter.Execute(message));
        }

        static async Task SendMessageAsync(string message)
        {
            Console.WriteLine($"[Server]: {message}");
            await WebSocketServer.CurrentConnection.SendAsync(message);
        }
    }


}
