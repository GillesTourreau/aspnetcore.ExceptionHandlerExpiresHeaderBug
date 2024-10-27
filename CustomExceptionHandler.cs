//-----------------------------------------------------------------------
// <copyright file="CustomExceptionHandler.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Text;
using Microsoft.AspNetCore.Diagnostics;

namespace ExceptionHandlerExpiresHeaderBug
{
    public class CustomExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            await httpContext.Response.Body.WriteAsync(Encoding.UTF8.GetBytes("The error"));

            // The httpContext.Response.Headers.Expires is automatically defined to "-1"...

            return true;
        }
    }
}
