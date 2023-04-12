﻿// This file is part of Hangfire. Copyright © 2016 Hangfire OÜ.
// 
// Hangfire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// Hangfire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with Hangfire. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using Hangfire.Annotations;

namespace Hangfire.Dashboard
{
    public static class OwinDashboardContextExtensions
    {
        public static IDictionary<string, object> GetOwinEnvironment([NotNull] this DashboardContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            var owinContext = context as OwinDashboardContext;
            if (owinContext == null)
            {
                throw new ArgumentException($"Context argument should be of type `{nameof(OwinDashboardContext)}`!", nameof(context));
            }

            return owinContext.Environment;
        }
    }
}