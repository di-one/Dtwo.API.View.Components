using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Navigation
{
    public interface IHyperLink : IComponent
    {
        string Path { get; set; }
        string Text { get; set; }
    }
}
