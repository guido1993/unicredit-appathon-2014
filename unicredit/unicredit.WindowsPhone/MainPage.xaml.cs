using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace unicredit
{

    public sealed partial class MainPage : Page
    {
        private bool _loadAnimation = true;

        private readonly DispatcherTimer _timer = new DispatcherTimer
        {
            Interval = new TimeSpan(0, 0, 0, 0, 350)
        };

        public MainPage()
        {
            this.InitializeComponent();

            _timer.Tick += (x, e) =>
            {
                if (!_loadAnimation) return;
                TopPanelAnimation.Begin();
                _loadAnimation = false;
            };

            _timer.Start();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            box_email.Text = "email@unicredit.it";
            box_password.Password = "aaaaaaaa";
        }

        private void Login_Click(object sender, TappedRoutedEventArgs e)
        {
            if ((box_email.Text != "") && (box_password.Password != ""))
            {
                this.Frame.Navigate(typeof(HomePage));
            }
        }
    }
}
