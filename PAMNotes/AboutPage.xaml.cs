namespace PAMNotes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void AboutButton_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/lucasns06");
    }

    private async void SteamButton_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://steamcommunity.com/id/Atrofy/");
    }
}