using Shop.ServerBusinessLogic;
using System.Collections.Generic;

namespace ServerPresentation
{
    class Route
    {
        private Dictionary<string, EndPoint> EndPointsRoute;

        public Route()
        {
            this.EndPointsRoute = new Dictionary<string, EndPoint>();
            this.EndPointsRoute.Add(
                "product",
                new ProductEndPoint(
                    new ProductSerializer()
                )
            );
        }

        public bool IsSupported(string Route)
        {
            return this.EndPointsRoute.ContainsKey(Route);
        }

        public EndPoint GetEndPoint(string Route)
        {

            return this.IsSupported(Route) ? this.EndPointsRoute[Route] : null;
        }
    }
}
