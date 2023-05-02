using Microsoft.Maui.Storage;
using SQLite;
using Microsoft.Data.Sqlite;
namespace Aloha_;

public partial class MainPage : ContentPage
{
    public class Person
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Company { get; set; } = "";
    }

    public MainPage()
	{
		InitializeComponent();
	}


    private async void AboutTour(object sender, EventArgs e)
	{
        await Navigation.PushModalAsync(new Registr());
    }

    private async void OnSearchButtonPressed(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Registr());
    }


}
