using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Threading.Tasks;

namespace FunctionsPerfTest
{
    public class HttpTriggerHighCPU
    {
        public static HttpResponseMessage Run(HttpRequestMessage req, TraceWriter log)
        {
            long max = 1000000000;
            var start = DateTime.Now;

            for (long i = 0; i < max; i++)
            {
                // Just spin CPU to simulate CPU intensive activity
            }

            return req.CreateResponse(HttpStatusCode.OK, $"Spinned CPU {max} times in {(DateTime.Now - start).TotalMilliseconds}ms");
        }
    }
}