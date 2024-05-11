using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface INumeric<TValue> : IComponent
    {
        TValue Value { get; set; }
        EventCallback<TValue> ValueChanged { get; set; }
        EventCallback<TValue> Change { get; set; }
        decimal? Min { get; set; }
        decimal? Max { get; set; }
        string Placeholder { get; set; }
        string Step { get; set; }
        string Format { get; set; }
        bool Disabled { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
        string Name { get; set; }
    }

}
