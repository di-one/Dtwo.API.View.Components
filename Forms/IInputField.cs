using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    public interface IInputField : IComponent
    {
        string PlaceHolder { get; set; }
        API.InputKey Value { get; set; }
        bool Disabled { get; set; }
        Action<API.InputKey> Change { get; set; }
        public string Name { get; set; }
    }
}
