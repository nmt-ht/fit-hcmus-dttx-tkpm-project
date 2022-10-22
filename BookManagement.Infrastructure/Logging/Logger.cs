namespace BookManagement.Infrastructure.Logging
{
    public class Logger
    {
        static public string POLICY_TRACE = "Logging Exception";

        public Logger()
        {
        }

        /// <summary>
        /// Log message to Text file
        /// </summary>
        /// <param name="message"></param>
        public static void LogToTextFile(string message)
        {
            //var factory = new LogWriterFactory();
            //using (var logWriter = factory.Create())
            //{
            //    logWriter.Write(message, "Trace");
            //}
        }
    }
}
