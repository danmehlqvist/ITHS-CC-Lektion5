using OpenClosed_slut;

namespace OpenClosed_start
{
    public class ErrorLogger
    {
        private readonly ILoggingStrategy _loggingStrategy;
        public ErrorLogger(ILoggingStrategy loggingStrategy)
        {
            _loggingStrategy = loggingStrategy;
        }

        public void LogError(string message)
        {
            _loggingStrategy.Log(message);
        }
    }
}
