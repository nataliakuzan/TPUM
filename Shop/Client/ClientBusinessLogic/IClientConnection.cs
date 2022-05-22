using System;
using System.Threading.Tasks;

namespace ClientBusinessLogic
{
    public interface IClientConnection
    {
        Action<string> ConnectionLogger { get; set; }

        bool Connected { get; }

        Task<bool> Connect(Uri peerUri);

        Task Disconnect();
    }
}
