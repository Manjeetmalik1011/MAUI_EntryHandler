namespace MAUIHandlers.Application.CustomControls;

public partial class MaterialEntry : ContentView
{
	public MaterialEntry()
	{
		InitializeComponent();
	}

    void MEEntry_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        ScalelabelDown();
    }

    void MEEntry_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        if(string.IsNullOrWhiteSpace(MEEntry.Text))
        {
            ScalelabelUp();
        }
    }
    private void ScalelabelDown()
    {
        MELabel.ScaleTo(0.8, 250, Easing.Linear);
        MELabel.TranslateTo(-50, -20, 250, Easing.Linear);
    }
    private void ScalelabelUp()
    {
        MELabel.ScaleTo(1, 250, Easing.Linear);
        MELabel.TranslateTo(0, 0, 250, Easing.Linear);
    }
}
