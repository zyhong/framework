﻿namespace Oqtane.Models
{
    public class PageModule
    {
        public int PageModuleId { get; set; }
        public int PageId { get; set; }
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public string Pane { get; set; }
        public int Order { get; set; }
        public string ContainerType { get; set; }

        public Module Module { get; set; }
    }
}
