using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMVC.IFR
{
    /// <summary>
    /// Servicio de log
    /// </summary>
    public static class Log
    {
        static ILog log = null;
        private static ILog Current{
            get{
                if(log == null){
                    log4net.Config.XmlConfigurator.Configure();
                    log = LogManager.GetLogger("TiendaMVC");
                }
                return log;
            }
            
        }
        /// <summary>
        /// Escribe un error en el log
        /// </summary>
        /// <param name="message">Texto del error</param>
        /// <param name="ex">Excepcion del error</param>
        public static void WriteError(string message, Exception ex = null)
        {
            log4net.LogManager.GetLogger("TiendaMVC").Error(message, ex);
        }
        /// <summary>
        /// Escribe un registro de info en el log
        /// </summary>
        /// <param name="message">Texto del error</param>
        /// <param name="ex">Excepcion del error</param>
        public static void WriteInfo(string message, Exception ex = null)
        {
            log4net.LogManager.GetLogger("TiendaMVC").Info(message, ex);
        }
        /// <summary>
        /// Escribe un registro de warning en el log
        /// </summary>
        /// <param name="message">Texto del error</param>
        /// <param name="ex">Excepcion del error</param>
        public static void WriteWarn(string message, Exception ex = null)
        {
            log4net.LogManager.GetLogger("TiendaMVC").Warn(message, ex);
        }
        /// <summary>
        /// Escribe un registro de fatal en el log
        /// </summary>
        /// <param name="message">Texto del error</param>
        /// <param name="ex">Excepcion del error</param>
        public static void WriteFatal(string message, Exception ex = null)
        {
            log4net.LogManager.GetLogger("TiendaMVC").Fatal(message, ex);
        }
    }
}
