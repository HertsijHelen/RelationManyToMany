//-----------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Artisans">
// Copyright (c) Artisans. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace RelationManyToMAny
{
    using System;
    using System.Web.Http;

    /// <summary>
    /// A Configuration of the Solution
    /// </summary>
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// Register GlobalConfiguration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);            
        }
    }
}