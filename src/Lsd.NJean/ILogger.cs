// <copyright file="ILogger.cs" company="Liquid Software Development">
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
    using System.Diagnostics.CodeAnalysis;

    #endregion

    /// <summary>
    /// The ILogger interface abstracts the logger from the template engine. 
    /// It is designed to reflect the common logging methods of the most
    /// popular loggers (log4net and nlog) for easy integration. 
    /// </summary>
    /// <author>
    /// <a href="mailto:george.labak@gmail.com">Labak</a>
    /// <a href="mailto:diadistis@gmail.com">Diadistis</a>
    /// </author>
    public interface ILogger
    {
        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Debug 
        /// level.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this logger is enabled for Debug events,
        ///     <c>false</c> otherwise.
        /// </value>
        bool IsDebugEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Info 
        /// level.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this logger is enabled for Info events,
        ///     <c>false</c> otherwise.
        /// </value>
        bool IsInfoEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Warn 
        /// level.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this logger is enabled for Warn events,
        ///     <c>false</c> otherwise.
        /// </value>
        bool IsWarnEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Error 
        /// level.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this logger is enabled for Error events,
        ///     <c>false</c> otherwise.
        /// </value>
        bool IsErrorEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether logging is enabled for the Fatal 
        /// level.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this logger is enabled for Fatal events,
        ///     <c>false</c> otherwise.
        /// </value>
        bool IsFatalEnabled { get; }

        /// <overloads>
        /// Writes the diagnostic message at the Debug level.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void Debug(string message);

        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// <param name="exception">The exception to be logged.</param>
        void Debug(string message, Exception exception);

        /// <overloads>
        /// Writes the diagnostic message at the Info level.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void Info(string message);

        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// <param name="exception">The exception to be logged.</param>
        void Info(string message, Exception exception);

        /// <overloads>
        /// Writes the diagnostic message at the Warn level.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void Warn(string message);

        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// <param name="exception">The exception to be logged.</param>
        void Warn(string message, Exception exception);

        /// <overloads>
        /// Writes the diagnostic message at the Error level.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        [SuppressMessage(
            "Microsoft.Naming", 
            "CA1716:IdentifiersShouldNotMatchKeywords", 
            MessageId = "Error", 
            Justification = "Kept for compatibility with nlog and log4net")]
        void Error(string message);

        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// <param name="exception">The exception to be logged.</param>
        [SuppressMessage(
            "Microsoft.Naming",
            "CA1716:IdentifiersShouldNotMatchKeywords",
            MessageId = "Error",
            Justification = "Kept for compatibility with nlog and log4net")]
        void Error(string message, Exception exception);

        /// <overloads>
        /// Writes the diagnostic message at the Fatal level.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        void Fatal(string message);

        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="message">The message to be logged.</param>
        /// <param name="exception">The exception to be logged.</param>
        void Fatal(string message, Exception exception);
    }
}
