using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace Ursa.Controls;

[TemplatePart(PART_CloseButton, typeof(Button))]
public class DialogControl: ContentControl
{
    public const string PART_CloseButton = "PART_CloseButton";
    
    
    
    private Button? _closeButton;
    public event EventHandler OnClose;

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
    }

    public void Show()
    {
        
    }
}