using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Net;

namespace Middleware.SharedTools
{
    static class Client
    {
        private const string vso_userName = "toto";
        private const string vso_url = "https://my.visualstudio.com/DefaultCollection";
        
        public static T GetClient<T>(string token) where T : VssHttpClientBase
        {
            var vs = new VssCredentials(new WindowsCredential(new NetworkCredential(vso_userName, token)));
            var vsconn = new VssConnection(new Uri(vso_url), vs);
            return vsconn.GetClient<T>();
        }
    }
}
