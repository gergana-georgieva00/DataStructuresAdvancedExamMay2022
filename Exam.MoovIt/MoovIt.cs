using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.MoovIt
{
    public class MoovIt : IMoovIt
    {
        private Dictionary<string, Route> routesById = new Dictionary<string, Route>();
        private HashSet<Route> routes = new HashSet<Route>();

        public int Count => routes.Count;

        public void AddRoute(Route route)
        {
            if (this.routes.Contains(route))
            {
                throw new ArgumentException();
            }

            routes.Add(route);
            routesById.Add(route.Id, route);
        }

        public void ChooseRoute(string routeId)
        {
            if (!routesById.ContainsKey(routeId))
            {
                throw new ArgumentException();
            }

            routesById[routeId].Popularity++;
        }

        public bool Contains(Route route)
            => routes.Contains(route);

        public IEnumerable<Route> GetFavoriteRoutes(string destinationPoint)
            => routes.Where(r => r.IsFavorite && r.LocationPoints.IndexOf(destinationPoint) > 0)
                .OrderBy(r => r.Distance)
                .ThenByDescending(r => r.Popularity);

        public Route GetRoute(string routeId)
        {
            if (!routesById.ContainsKey(routeId))
            {
                throw new ArgumentException();
            }

            return routesById[routeId];
        }

        public IEnumerable<Route> GetTop5RoutesByPopularityThenByDistanceThenByCountOfLocationPoints()
            => routes.OrderByDescending(r => r.Popularity)
               .ThenBy(r => r.Distance)
               .ThenBy(r => r.LocationPoints.Count)
               .Take(5);

        public void RemoveRoute(string routeId)
        {
            if (!routesById.ContainsKey(routeId))
            {
                throw new ArgumentException();
            }

            var route = routesById[routeId];

            routes.Remove(route);
            routesById.Remove(routeId);
        }

        public IEnumerable<Route> SearchRoutes(string startPoint, string endPoint)
            => routes.Where(r => r.LocationPoints.Contains(startPoint)
                              && r.LocationPoints.Contains(endPoint)
                              && r.LocationPoints.IndexOf(startPoint) < r.LocationPoints.IndexOf(endPoint))
            .OrderBy(r => r.IsFavorite)
            .ThenBy(r => r.LocationPoints.IndexOf(endPoint) - r.LocationPoints.IndexOf(startPoint))
            .ThenByDescending(r => r.Popularity);
    }
}
