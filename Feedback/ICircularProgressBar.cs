namespace Dtwo.API.View.Components.Feedback
{
    public interface ICircularProgressBar : IComponent
    {
        Dictionary<string, object> AdditionalAttributes { get; set; }
        EProgressBarMode Mode { get; set; }
        EProgressBarStyle Style { get; set; }
        ECircularProgressBarSize Size { get; set; }
        int Value { get; set; }
        bool ShowValue { get; set; }
        string Unit { get; set; }
    }
}
