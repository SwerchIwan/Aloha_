namespace Aloha_;

public partial class Registr : ContentPage
{
	public Registr()
	{
		InitializeComponent();
	}
    private async void ToSignInPage(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SignIn());
    }
}