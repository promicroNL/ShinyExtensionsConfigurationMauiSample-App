using Microsoft.Extensions.Configuration;

namespace MauiApp3;

public partial class MainPage : ContentPage
{
    private readonly IConfiguration _configuration;

	public MainPage(IConfiguration configuration)
	{
		InitializeComponent();
        _configuration = configuration;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        CounterBtn.Text = _configuration["myAppSetting"];

        SemanticScreenReader.Announce(CounterBtn.Text);

        _configuration["myAppSetting"] += "->Bye";
	}
}

