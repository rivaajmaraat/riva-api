using System;
using System.Collections.Generic;
using System.Text;

namespace Hayden.Services
{
    public enum ResponseMessage
    {
        /// <summary>
        /// Response message type for success
        /// </summary>
        Success,
        /// <summary>
        /// Response message type for exception
        /// </summary>
        Exception,
        /// <summary>
        /// Response message type for miscellaneous error
        /// </summary>
        MiscError
    }
}
