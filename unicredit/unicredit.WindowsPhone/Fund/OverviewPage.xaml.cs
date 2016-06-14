using unicredit.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace unicredit.Fund
{

    public sealed partial class OverviewPage : Page
    {
        public OverviewPage()
        {
            this.InitializeComponent();
            NavigationHelper helper = new NavigationHelper(this);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            box_fund_list.Items.Add(new Data() { Id = "1", Name = "Gita S.Vito di Cadore", Total = "13234.12€" });
            box_fund_list.Items.Add(new Data() { Id = "2", Name = "Associazione Calcistica", Total = "4092.40€" });
            box_fund_list.Items.Add(new Data() { Id = "3", Name = "Famiglia", Total = "2312.80€" });

            box_action_list.Items.Add(new Data() { Id = "1", Name = "Crea Fondo", Info = "" });
        }

        private void View_Fund(object sender, SelectionChangedEventArgs e)
        {

            var data = (sender as ListView).SelectedItem as Data;
            var id = data.Id;

            Frame.Navigate(typeof(SinglePage), id);
        }

        private void View_Page(object sender, SelectionChangedEventArgs e)
        {

            var data = (sender as ListView).SelectedItem as Data;
            var id = data.Id;

            if (id == "1") Frame.Navigate(typeof(AddPage));
        }

    }
}
