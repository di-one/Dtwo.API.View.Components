using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Layout
{
    public interface IGrid : IComponent
    {
        RenderFragment ChildContent { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
        EJustifyContent JustifyContent { get; set; }
        EAlignItems AlignItems { get; set; }
        string Gap { get; set; }
    }
}
