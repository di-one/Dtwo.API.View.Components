using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Navigation
{
    public class Tab
    {
        public readonly string Text;
        public readonly Type Component;

        public Tab(string text, Type component)
        {
            Text = text;
            Component = component;
        }
    }
}
