using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface ITemplateForm<TItem> : IComponent
    {
        RenderFragment ChildContent { get; set; }
        TItem Data { get; set; }
        EventCallback<TItem> Submit { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
    }
}
