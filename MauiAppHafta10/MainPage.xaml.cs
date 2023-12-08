namespace MauiAppHafta10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblLabel1.Text = e.NewValue.ToString("F0");
        }

        private void DarkModeOnOff(object sender, ToggledEventArgs e)
        {
            if (e.Value)
                Application.Current.UserAppTheme = AppTheme.Dark;
            else
                Application.Current.UserAppTheme = AppTheme.Light;
        }
    }
}