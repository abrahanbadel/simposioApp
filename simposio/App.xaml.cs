namespace simposio
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutPage { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public void SetTheme(bool isDarkMode)
        {
            if (isDarkMode)
            {
                Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                Current.UserAppTheme = AppTheme.Light;
            }
        }

    }
}
