﻿using System;

namespace BetterCms.Module.Pages.Command.Content.GetChildContentOptions
{
    public class GetChildContentOptionsCommandRequest
    {
        public Guid ContentId { get; set; }
        
        public Guid AssignmentIdentifier { get; set; }
    }
}