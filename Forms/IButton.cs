using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
	public interface IButton : IComponent
	{
		RenderFragment ChildContent { get; set; }
		Action<MouseEventArgs> OnClicked { get; set; }
        Theming.EColor Color { get; set; }
		Theming.EVariant Variant { get; set; }
		EButtonSize Size { get; set; }
		bool IsBusy { get; set; }
		string BusyText { get; set; }
		bool Disabled { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
    }
}
