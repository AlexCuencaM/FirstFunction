using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
namespace Video.Function
{
    public class video_uploader_v2
    {
        private readonly ILogger _logger;

        public video_uploader_v2(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<video_uploader_v2>();
        }

        [Function("video_uploader_v2")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            await Task.Delay(100);
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
