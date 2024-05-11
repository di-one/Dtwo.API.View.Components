using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface IDropDown<TValue> : IComponent
    {
        TValue Value { get; set; }
        IEnumerable<object> Data { get; set; }
        string Name { get; set; }
        EventCallback<TValue> ValueChanged { get; set; }
        EventCallback<object> Change { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
    }

}
