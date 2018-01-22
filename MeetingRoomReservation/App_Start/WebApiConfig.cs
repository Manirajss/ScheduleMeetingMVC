using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MeetingRoomReservation
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            //todo: remove this
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}",
            //    defaults: new { action = "Get" }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApiId",
            //    routeTemplate: "api/{controller}/{action}/{id:int}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.MapHttpAttributeRoutes();
        }
    }
}
