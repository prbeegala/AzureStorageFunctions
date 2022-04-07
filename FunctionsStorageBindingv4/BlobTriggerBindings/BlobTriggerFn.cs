using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace BlobTriggerBindings
{
    public class BlobTriggerFn
    {
        [FunctionName("BlobTriggerFn")]
        public void Run([BlobTrigger("triggercontainer/{name}", Connection = "pbstorageCONN")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
