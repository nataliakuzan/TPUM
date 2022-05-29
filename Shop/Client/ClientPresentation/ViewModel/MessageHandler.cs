using System;
using System.Collections.Generic;
using ServerPresentation;

namespace Shop.Presentation.ViewModel
{
    class MessageHandler
    {
        private Dictionary<string, Action<string>> CommandNameAction;

        public MessageHandler()
        {
            CommandNameAction = new Dictionary<string, Action<string>>();
        }

        public void addCommandHandler(string Command, Action<string> Handler)
        {
            CommandNameAction.Add(Command, Handler);
        }

        public void HandleMessage(string message)
        {
            CommandParser commandParser = new CommandParser(message);

            if (IsHandlingCommand(MergeCommandRouteAndAction(commandParser))) {
                Action<string> Handler = GetActionForCommand(MergeCommandRouteAndAction(commandParser));
                Handler?.Invoke(commandParser.getContent());
            } else
            {
                Console.WriteLine("Route and action don't exist");
            }
        }

        private bool IsHandlingCommand(string Command)
        {
            return CommandNameAction.ContainsKey(Command);
        }

        private Action<string> GetActionForCommand(string Command)
        {
            return CommandNameAction[Command];
        }

        private string MergeCommandRouteAndAction(CommandParser commandParser)
        {
            return commandParser.getRoute() + " " + commandParser.getAction();
        }
    }
}
