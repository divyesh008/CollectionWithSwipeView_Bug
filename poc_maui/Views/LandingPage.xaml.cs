namespace poc_maui.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}

    void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        Application.Current.MainPage.DisplayAlert("Alert", "Delete Command Triggered", "OK");
    }
}
