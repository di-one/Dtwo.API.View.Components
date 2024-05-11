using Microsoft.AspNetCore.Components;

namespace Dtwo.API.View.Components.Layout
{
    public interface IMainLayout : IComponent
    {
        MainLayoutSettings Settings { get; set; }
        bool IsLoading { get; set; }
        RenderFragment ChildContent { get; set; }
    }
}
