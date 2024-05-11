namespace Dtwo.API.View.Components.Images
{
    public interface IIcon : IComponent
    {
        string Icon { get; set; }
        EIconColor Color { get; set; }
    }
}
