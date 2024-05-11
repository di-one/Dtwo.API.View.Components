using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface ISwitch : IComponent
    {
        bool Value { get; set; }
        bool Disabled { get; set; }
        string Name { get; set; }
        EventCallback<bool> Change { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
    }

}
