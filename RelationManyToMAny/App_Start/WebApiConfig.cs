//-----------------------------------------------------------------------
// <copyright file="WebApiConfig.cs" company="Artisans">
//     Copyright (c) Artisans. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-----------------------------------------------------------------------

namespace RelationManyToMAny
{  
    using System.Net.Http.Headers;
    using System.Web.Http;

    /// <summary>
    /// The Configuration of WebApi
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register 
        /// </summary>
        /// <param name="config">Parameters for Configuration</param>
        public static void Register(HttpConfiguration config)
        {
           config.MapHttpAttributeRoutes();
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
            config.Routes.MapHttpRoute(
               name: "ApiByActionAndId",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { action = "Get" });
        }
    }
}
