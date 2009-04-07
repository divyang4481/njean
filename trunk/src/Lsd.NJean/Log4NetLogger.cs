// <copyright file="Log4NetLogger.cs" company="Liquid Software Development">
// Copyright 2008-2009 Liquid Software Development - http://www.liquidsd.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace Lsd.NJean
{
    #region Imports

    using System;
    using log4net;

    #endregion

    /// <summary>
    /// Log4NetLogger is a simple implementation of ILogger in Log4Net.
    /// </summary>
    /// <author>   
    /// <a href="mailto:laodimos@gmail.com">Laodimos</a>
    /// </author>
    public partial class Log4NetLogger : ILogger
    {
        private ILog logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetLogger"/> class.
        /// </summary>
        public Log4NetLogger() 
        {
            this.logger = LogManager.GetLogger(typeof(Log4NetLogger));
        }
    }

    public partial class Log4NetLogger
    {
        #region ILogger Members

        /// <summary>
        /// Gets a value indicating whether the logger's debug level is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if debug level is enabled; 
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsDebugEnabled
        {
            get 
            {
                if (this.logger.IsDebugEnabled)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the logger's info level is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if info level is enabled; 
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsInfoEnabled
        {
            get 
            {
                if (this.logger.IsInfoEnabled)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the logger's Warn level is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if warn level is enabled; 
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsWarnEnabled
        {
            get 
            {
                if (this.logger.IsWarnEnabled)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the logger's Error level is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if error level is enabled; 
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsErrorEnabled
        {
            get 
            {
                if (this.logger.IsErrorEnabled)
                {
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the logger's Fatal level is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if fatal level is enabled; 
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsFatalEnabled
        {
            get
            {
                if (this.logger.IsFatalEnabled)
                {
                    return true;
                }

                return false;
            }
        }

        /// <overloads>
        /// Logs the specified Debug level message. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Logs the specified Debug level message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            if (this.logger.IsDebugEnabled)
            {
                this.logger.Debug(message);
            }
        }

        /// <summary>
        /// Logs the specified Debug level message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(string message, Exception exception)
        {
            if (this.logger.IsDebugEnabled)
            {
                this.logger.Debug(message, exception);
            }
        }

        /// <overloads>
        /// Logs the specified Info level message. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Logs the specified Info level message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            if (this.logger.IsInfoEnabled)
            {
                this.logger.Info(message);
            }
        }

        /// <summary>
        /// Logs the specified Info level message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(string message, Exception exception)
        {
            if (this.logger.IsInfoEnabled)
            {
                this.logger.Info(message, exception);
            }
        }

        /// <overloads>
        /// Logs the specified Warn level message. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Logs the specified Warn level message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warn(string message)
        {
            if (this.logger.IsWarnEnabled)
            {
                this.logger.Warn(message);
            }
        }

        /// <summary>
        /// Logs the specified Warn level message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(string message, Exception exception)
        {
            if (this.logger.IsWarnEnabled)
            {
                this.logger.Warn(message, exception);
            }
        }

        /// <overloads>
        /// Logs the specified Error level message. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Logs the specified Error level message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
            if (this.logger.IsErrorEnabled)
            {
                this.logger.Error(message);
            }
        }

        /// <summary>
        /// Logs the specified Error level message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(string message, Exception exception)
        {
            if (this.logger.IsErrorEnabled)
            {
                this.logger.Error(message, exception);
            }
        }

        /// <overloads>
        /// Logs the specified Fatal level message. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Logs the specified Fatal level message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Fatal(string message)
        {
            if (this.logger.IsFatalEnabled)
            {
                this.logger.Fatal(message);
            }
        }

        /// <summary>
        /// Logs the specified Fatal level message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(string message, Exception exception)
        {
            if (this.logger.IsFatalEnabled)
            {
                this.logger.Fatal(message, exception);
            }
        }

        #endregion
    }
}
