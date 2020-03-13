using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riva.Api.Models.Responses
{
    public enum ResponseState
    {
        /// <summary>
        /// Success response state
        /// </summary>
        Success,
        /// <summary>
        /// Error response state
        /// </summary>
        Error,
        /// <summary>
        /// Exception response state
        /// </summary>
        Exception
    }
}
