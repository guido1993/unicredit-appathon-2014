using unicredit.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace unicredit.Fund
{
    public sealed partial class AddPage : Page
    {
        public AddPage()
        {
            this.InitializeComponent();
            NavigationHelper helper = new NavigationHelper(this);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
