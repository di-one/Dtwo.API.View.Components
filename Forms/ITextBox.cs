using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface ITextBox : IComponent
    {
        EventCallback<string> Change { get; set; }
        string PlaceHolder { get; set; }
        int MaxLength { get; set; }
        bool Disabled { get; set; }
        bool AutoComplete { get; set; }
        string Value { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
        string Name { get; set; }
    }
}
