using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riva.Api.Models.Responses
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
