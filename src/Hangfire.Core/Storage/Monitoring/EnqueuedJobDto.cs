﻿// This file is part of Hangfire. Copyright © 2013-2014 Hangfire OÜ.
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
using Hangfire.Common;

namespace Hangfire.Storage.Monitoring
{
    public class EnqueuedJobDto
    {
        public EnqueuedJobDto()
        {
            InEnqueuedState = true;
        }

        public Job Job { get; set; }
        public JobLoadException LoadException { get; set; }
        public InvocationData InvocationData { get; set; }
        public string State { get; set; }
        public DateTime? EnqueuedAt { get; set; }
        public bool InEnqueuedState { get; set; }
        public IDictionary<string, string> StateData { get; set; }
    }
}