using Dtwo.API.View.Components.Theming;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Layout
{
    public interface ICard : IComponent
    {
        RenderFragment ChildContent { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
        EVariant Variant { get; set; }
    }
}
