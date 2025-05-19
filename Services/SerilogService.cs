namespace WebApi.Services
{
    public class SerilogService(ILogger<SerilogService> logger) : ISerilogService
    {
        public void log()
        {
            logger.LogInformation("Information");
            logger.LogCritical("oops");
            logger.LogDebug("nothing much");
        }
    }
}
