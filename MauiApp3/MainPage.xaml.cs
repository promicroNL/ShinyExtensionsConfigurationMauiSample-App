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

	private void OnButtonClick(object sender, EventArgs e)
	{
        ConfigKeyBtn.Text = _configuration["myAppSetting"];

        SemanticScreenReader.Announce(ConfigKeyBtn.Text);

        if (_configuration["myAppSetting"] == "Hello")
            _configuration["myAppSetting"] = "Bye";
        else
            _configuration["myAppSetting"] = "Hello";

    }
}

