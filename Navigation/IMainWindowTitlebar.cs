using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Navigation
{
    public interface IMainWindowTitlebar : IComponent
    {
        Action<MouseEventArgs> OnMouseMove { get; set; }
        Action<MouseEventArgs> OnMouseDown { get; set; }
        Action<MouseEventArgs> OnMouseUp { get; set; }

        Action OnClickMinimize{ get; set; }
        Action OnClickMaximize { get; set; }
        Action OnClickClose { get; set; }
    }
}
