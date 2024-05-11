using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Typography
{
    public interface IText : IComponent
    {
        RenderFragment ChildContent { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }

        ETextStyle TextStyle { get; set; }
        ETextAlign TextAlign { get; set; }
    }
}
