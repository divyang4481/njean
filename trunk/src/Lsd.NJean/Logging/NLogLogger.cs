// <copyright file="NLogLogger.cs" company="Liquid Software Development">
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

namespace Lsd.NJean.Logging
{
    #region Imports

    using System;
    using NLog;

    #endregion

    /// <summary>
    /// NLog implementation of <see cref="Lsd.NJean.Logging.ILogger"/>
    /// </summary>
    /// <author>   
    /// <a href="mailto:laodimos@gmail.com">Laodimos</a>
    /// <a href="mailto:diadistis@gmail.com">Diadists</a>
    /// </author>
    public partial class NLogLogger : ILogger
    {
        private Logger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogLogger"/> class.
        /// </summary>
        public NLogLogger()
        {
            this.logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogLogger"/> class.
        /// </summary>
        /// <param name="name">The logger name.</param>
        public NLogLogger(string name)
        {
            this.logger = LogManager.GetLogger(name);
        }
    }

    public partial class NLogLogger
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
            get { return this.logger.IsInfoEnabled; }
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
            get { return this.logger.IsWarnEnabled; }
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
            get { return this.logger.IsErrorEnabled; }
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
            get { return this.logger.IsFatalEnabled; }
        }

        /// <overloads>
        /// Writes the diagnostic message at the Debug level. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            this.logger.Debug(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(string message, Exception exception)
        {
            this.logger.DebugException(message, exception);
        }

        /// <overloads>
        /// Writes the diagnostic message at the Info level. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            this.logger.Info(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(string message, Exception exception)
        {
            this.logger.InfoException(message, exception);
        }

        /// <overloads>
        /// Writes the diagnostic message at the Warn level. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warn(string message)
        {
            this.logger.Warn(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(string message, Exception exception)
        {
            this.logger.WarnException(message, exception);
        }

        /// <overloads>
        /// Writes the diagnostic message at the Error level. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
            this.logger.Error(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(string message, Exception exception)
        {
            this.logger.ErrorException(message, exception);
        }

        /// <overloads>
        /// Writes the diagnostic message at the Fatal level. 
        /// Can be addressed with an exception to be included in the log.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Fatal(string message)
        {
            this.logger.Fatal(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(string message, Exception exception)
        {
            this.logger.FatalException(message, exception);
        }

        #endregion
    }
}
