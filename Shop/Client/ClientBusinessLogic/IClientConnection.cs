using System;
using System.Threading.Tasks;

namespace ClientBusinessLogic
{
    public interface IClientConnection
    {
        bool Connected { get; }

        Task<bool> Connect(Uri peerUri);

        Task Disconnect();

        Task SendAsync(string message);
    }
}
