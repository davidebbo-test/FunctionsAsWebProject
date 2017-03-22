using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Threading.Tasks;

namespace FunctionsLibraryProject
{
    public class HttpTriggerHighCPU
    {
        public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
        {
            int max = 100000000;

            for (int i = 0; i < max; i++)
            {
                // Just spin CPU to simulate CPU intensive activity
            }

            return req.CreateResponse(HttpStatusCode.OK, $"Spinned {max} times");
        }
    }
}