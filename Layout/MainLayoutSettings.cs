using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Layout
{
    public class MainLayoutSettings
    {
        public class SidebarEntry
        {
            public string Name { get; set; }
            public string Icon { get; set; }
            public string Url { get; set; }

            public Func<bool> IsVisible { get; set; }

            public List<SidebarEntry> Childs { get; set; }
        }

        private readonly List<SidebarEntry> m_sideBarEntries = new List<SidebarEntry>();
        public List<SidebarEntry> SideBarEntries => m_sideBarEntries;

        public MainLayoutSettings(List<SidebarEntry> sideBarEntries)
        {
            m_sideBarEntries = sideBarEntries;
        }
    }
}
