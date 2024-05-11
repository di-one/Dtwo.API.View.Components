using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface IFieldLayout : IComponent
    {
        bool AllowCollapse { get; set; }
        string ExpandTitle { get; set; }
        string CollapseTitle { get; set; }
        string ExpandAriaLabel { get; set; }
        string CollapseAriaLabel { get; set; }
        EventCallback Expand { get; set; }
        string Text { get; set; }
        bool Collapse { get; set; }
        RenderFragment ChildContent { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
    }
}
