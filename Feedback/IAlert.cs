using Dtwo.API.View.Components.Theming;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Feedback
{
    public interface IAlert : IComponent
    {
        EAlertStyle Style { get; set; }
        EVariant Variant { get; set; }
        RenderFragment ChildContent { get; set; }
        bool ShowIcon { get; set; }
    }
}
