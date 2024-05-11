using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Layout
{
    public interface IStack : IComponent
    {
        RenderFragment ChildContent { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
        EStackOrientation Orientation { get; set; }
        EJustifyContent JustifyContent { get; set; }
        string Gap { get; set; }
        EWrap Wrap { get; set; }
    }
}
