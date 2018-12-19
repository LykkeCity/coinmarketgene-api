using System;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace cmg_hosting_api.Middleware
{
    public static class DefaultPageMiddleware
    {

        private static string _content;


        private const string RootPage = "wwwroot/index.html";

        private static void LoadContent()
        {
            
            try
            {
                _content = File.ReadAllText(RootPage);
            }
            catch (Exception)
            {
                _content = $"{RootPage} page is not found"  ;
            }
        }
            
            
        public static void UseDefaultPage(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                if (_content == null)
                    LoadContent();

                await context.Response.WriteAsync(_content); 

            });
        }
    }
}