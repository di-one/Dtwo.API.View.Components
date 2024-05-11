using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Layout
{
    public interface IGridItem : IComponent
    {
        RenderFragment ChildContent { get; set; }
        Dictionary<string, object> AdditionalAttributes { get; set; }
        
        int? Size { get; set; }
        int? SizeXS { get; set; }
        int? SizeSM { get; set; }
        int? SizeMD { get; set; }
        int? SizeLG { get; set; }
        int? SizeXL { get; set; }
        int? SizeXX { get; set; }

        int? Offset { get; set; }
        int? OffsetXS { get; set; }
        int? OffsetSM { get; set; }
        int? OffsetMD { get; set; }
        int? OffsetLG { get; set; }
        int? OffsetXL { get; set; }
        int? OffsetXX { get; set; }

        string Order { get; set; }
        string OrderXS { get; set; }
        string OrderSM { get; set; }
        string OrderMD { get; set; }
        string OrderLG { get; set; }
        string OrderXL { get; set; }
        string OrderXX { get; set; }

    }
}
