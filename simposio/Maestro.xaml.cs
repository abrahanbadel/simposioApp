namespace simposio;

public partial class Maestro : ContentPage
{
	public Maestro()
	{
		InitializeComponent();
	}

    private void goToPage(ContentPage page)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(page);
        App.FlyoutPage.IsPresented = false;  // Cierra el men� Flyout despu�s de la navegaci�n
    }

    private void GotoInnovationPage(object sender, EventArgs e)
    {
        goToPage(new Pages.NewPage1());
    }

    private void GotoCronogramaPage(object sender, EventArgs e)
    {
        goToPage(new Pages.CronogramaPage());
    }
}