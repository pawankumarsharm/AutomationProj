using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SelectGermany.Logger
{
    class GenerateLogs
    {
        #region Field
        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "Logs");
        private static ILog _logger;
        private static ConsoleAppender _consoleAppender;
        private static FileAppender _fileAppender;
        private static RollingFileAppender _rollingFileAppender;
        private static string _layout = "%date{dd-MMM-yyyy-HH:mm:ss,fff} [%class] [%level] [%method] - %message%newline";
        #endregion

        #region Property
        public static string Layout
        {
            set { _layout = value; }
        }
        #endregion

        #region Private
        private static PatternLayout GetPatternLayout()
        {
            var patterLayout = new PatternLayout()
            {
                ConversionPattern = _layout
            };
            patterLayout.ActivateOptions();
            return patterLayout;
        }

        private static ConsoleAppender GetConsoleAppender()
        {
            var consoleAppender = new ConsoleAppender()
            {
                Name = "ConsoleAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All
            };
            consoleAppender.ActivateOptions();
            return consoleAppender;
        }
        private static FileAppender GetFileAppender()
        {
            var fileAppender = new FileAppender()
            {
                Name = "FileAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All,
                AppendToFile = true,
                File = "Tc_RunLogs.log",

            };
            fileAppender.ActivateOptions();
            return fileAppender;
        }
        private static RollingFileAppender GetRollingFileAppender()
        {
            var rollingFileAppender = new RollingFileAppender()
            {
                Name = "FileAppender",
                Layout = GetPatternLayout(),
                Threshold = Level.All,
                AppendToFile = false,
                File = "RollingFileLogger.log",
                MaximumFileSize = "1MB",
                MaxSizeRollBackups = 5,
            };
            rollingFileAppender.ActivateOptions();
            return rollingFileAppender;
        }
        #endregion
        #region Public
        public static ILog GetLogger(Type type)
        {
            if (_consoleAppender == null)
                _consoleAppender = GetConsoleAppender();
            if (_fileAppender == null)
                _fileAppender = GetFileAppender();
            if (_rollingFileAppender == null)
                _rollingFileAppender = GetRollingFileAppender();
            if (_logger != null)
                return _logger;

            BasicConfigurator.Configure(_consoleAppender, _fileAppender, _rollingFileAppender);
            _logger = LogManager.GetLogger(type);
            return _logger;
        }
        #endregion
    }
}
