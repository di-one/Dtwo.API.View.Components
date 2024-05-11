using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface ILabel : IComponent
    {
       string Text { get; set; }
       string Component { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
    }
}
