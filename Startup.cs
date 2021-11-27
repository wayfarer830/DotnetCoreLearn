using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace HelloWorld{
    public class Startup{
        public Startup(IHostingEnvironment environment)
        {}

        public void Configure(IApplicationBuilder applicationBuilder,IHostingEnvironment environment,ILoggerFactory loggerFactory)
        {
            applicationBuilder.Run(
                async(context)=>{
                    await context.Response.WriteAsync("Hello,World!");
                }
            );            
        }
    }
}