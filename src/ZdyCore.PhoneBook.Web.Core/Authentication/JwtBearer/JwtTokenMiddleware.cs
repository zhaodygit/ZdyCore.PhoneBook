﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;

namespace ZdyCore.PhoneBook.Authentication.JwtBearer
{
    public static class JwtTokenMiddleware
    {
        //public static IApplicationBuilder UseJwtTokenMiddleware(this IApplicationBuilder app, string schema = JwtBearerDefaults.AuthenticationScheme)
        //{
        //    return app.Use(async (ctx, next) =>
        //    {
        //        if (ctx.User.Identity?.IsAuthenticated != true)
        //        {
        //            var result = await ctx.AuthenticateAsync(schema);
        //            if (result.Succeeded && result.Principal != null)
        //            {
        //                ctx.User = result.Principal;
        //            }
        //        }

        //        await next();
        //    });
        //}

        public static IApplicationBuilder UseJwtTokenMiddleware(this IApplicationBuilder app)
        {
            return app.Use(async (ctx, next) =>
            {
                if (ctx.User.Identity?.IsAuthenticated != true)
                {
                    var result = await ctx.AuthenticateAsync(JwtBearerDefaults.AuthenticationScheme);
                    if (result.Succeeded && result.Principal != null)
                    {
                        ctx.User = result.Principal;
                    }
                }

                await next();
            });
        }
    }
}
