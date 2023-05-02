namespace Aloha_;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}
    private async void ToRegistrPage(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Registr());
    }
}