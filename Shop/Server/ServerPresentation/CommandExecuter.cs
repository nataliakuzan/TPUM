namespace ServerPresentation
{
    class CommandExecuter
    {
        private string Response;

        private CommandParser commandParser;

        private Route Routes;

        public CommandExecuter()
        {
            Routes = new Route();
        }

        public string Execute(string message)
        {
            if (!Parse(message))
            {
                return Response;
            }

            string Route = commandParser.getRoute();

            if (!IsRouteSupported(Route))
            {
                return Response;
            }

            ExecuteAction(Routes.GetEndPoint(Route));

            return Response;
        }

        private bool Parse (string message)
        {
            commandParser = new CommandParser(message);

            if (commandParser.isError())
            {
                Response = commandParser.getError();
                return false;
            }

            return true;
        }
        
        private bool IsRouteSupported(string Route)
        {
            if (!Routes.IsSupported(Route))
            {
                Response = "Route does not exist";
                return false;
            }
            return true;
        }

        private bool ExecuteAction(EndPoint Endpoint)
        {
            switch (commandParser.getAction())
            {
                case "ListAll":
                    Response = Endpoint.ListAll();
                    break;
                case "Create":
                    Response = Endpoint.Create();
                    break;
                default:
                    Response = "Action does not exist";
                    break;
            }
            return true;
        }
    }
}
