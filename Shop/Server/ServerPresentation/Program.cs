using Shop.ServerBusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerPresentation
{
    class Program
    {
        public static IBusinessLogicLayer businessLogic;

        static async Task Main(string[] args)
        {
            businessLogic = new BusinessLogicLayer();
            businessLogic.Shop.Initialize();
            Console.WriteLine("Server started");
            await WebSocketServer.Server(8081, ConnectionHandler);
        }

        static void ConnectionHandler(WebSocketConnection webSocketConnection)
        {
            Console.WriteLine("[Server]: Client connected");
            WebSocketServer.CurrentConnection = webSocketConnection;
            webSocketConnection.onMessage = ParseMessage;
            webSocketConnection.onClose = () => { Console.WriteLine("[Server]: Connection closed"); };
            webSocketConnection.onError = () => { Console.WriteLine("[Server]: Connection error encountered"); };
        }

        static async void ParseMessage(string message)
        {
            Console.WriteLine($"[Client]: {message}");
            Route Routes = new Route();

            EndPoint Endpoint = Routes.GetEndPoint(GetRoute(message));

            string Response;

            switch (GetAction(message))
            {
                case "ListAll":
                    Response = Endpoint.ListAll();
                    break;
                case "Create":
                    Response = Endpoint.Create();
                    break;
                default:
                    Response = "Method does not exist";
                    break;
            }

            await SendMessageAsync(Response);
        }

        static string GetRoute(string message)
        {
            return "product";
        }

        static string GetAction(string message)
        {
            return "ListAll";
        }

        static async Task SendMessageAsync(string message)
        {
            Console.WriteLine($"[Server]: {message}");
            await WebSocketServer.CurrentConnection.SendAsync(message);
        }
    }


}
