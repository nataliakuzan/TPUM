using System;

namespace ServerPresentation
{
    public class CommandParser
    {
        private String Route;
        private String Action;
        private String Content;
        private String Error;
        private bool IsError;

        public CommandParser(string Command)
        {
            this.IsError = false;
            String[] elements = Parse(Command);
            
            if (!IsError)
            {
                this.Route = elements[0];
                this.Action = elements[1];

                if (elements.Length > 2)
                {
                    this.Content = elements[2];
                }
            }
        }

        public String getRoute()
        {
            return this.Route;
        }

        public String getAction()
        {
            return this.Action;
        }

        public String getContent()
        {
            return this.Content;
        }

        public bool isError()
        {
            return this.IsError;
        }

        public String getError()
        {
            return this.Error;
        }

        private String[] Parse(string Command)
        {
            char[] separator = { ' ' };
            String[] elements = Command.Split(separator, 3);

            if (elements.Length < 2)
            {
                IsError = true;
                Error = "Command needs a route and an action";
            }

            return elements;
        }
    }
}
