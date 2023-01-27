using System;
using System.Collections.Generic;

namespace Exam.MoovIt
{
    public class MoovIt : IMoovIt
    {
        //private Dictionary<string, Route> routesById = new Dictionary<string, Route>();
        private HashSet<Route> routes = new HashSet<Route>();

        public int Count => routes.Count;

        public void AddRoute(Route route)
        {
            if (this.routes.Contains(route))
            {
                throw new ArgumentException();
            }

            routes.Add(route);
        }

        public void ChooseRoute(string routeId)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Route route)
            => routes.Contains(route);

        public IEnumerable<Route> GetFavoriteRoutes(string destinationPoint)
        {
            throw new NotImplementedException();
        }

        public Route GetRoute(string routeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Route> GetTop5RoutesByPopularityThenByDistanceThenByCountOfLocationPoints()
        {
            throw new NotImplementedException();
        }

        public void RemoveRoute(string routeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Route> SearchRoutes(string startPoint, string endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
