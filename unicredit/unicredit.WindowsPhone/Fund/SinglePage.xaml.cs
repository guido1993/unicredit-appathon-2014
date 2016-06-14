using unicredit.Common;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace unicredit.Fund
{

    public sealed partial class SinglePage : Page
    {

        public SinglePage()
        {
            this.InitializeComponent();
            NavigationHelper helper = new NavigationHelper(this);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            var id = parameter;

            if (id == "1")
            {
                box_item_list.Items.Add(new Data() { Name = "Ragione", Info = "Gita S.Vito di Cadore", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "Intestatario", Info = "Bruno Luca", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "c/c n.°", Info = "7294 8273 3272 4882", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "Saldo totale", Info = "200€", Color = "Bold" });
            }

            if (id == "2")
            {
                box_item_list.Items.Add(new Data() { Name = "Ragione", Info = "Associazione Calcistica", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "Intestatario", Info = "Luca Montanari", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "c/c n.°", Info = "7294 8273 3272 4882", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "Saldo totale", Info = "4092.40€", Color = "Bold" });
            }

            if (id == "3")
            {
                box_item_list.Items.Add(new Data() { Name = "Ragione", Info = "Famiglia", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "Intestatario", Info = "Guido Magrin", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "c/c n.°", Info = "7294 8273 3272 4882", Color = "Normal" });
                box_item_list.Items.Add(new Data() { Name = "Saldo totale", Info = "2312.80€", Color = "Bold" });
            }

            box_action_personal_list.Items.Add(new Data() { Id = "1", Name = "Lista Acconti e Prelievi", Info = "" });
            box_action_personal_list.Items.Add(new Data() { Id = "2", Name = "Messaggi & Informazioni", Info = "" });

            box_action_fund_list.Items.Add(new Data() { Name = "Effettua versamento", Info = "" });
            box_action_fund_list.Items.Add(new Data() { Name = "Modifica informazioni", Info = "" });

        }

        private void View_Page(object sender, SelectionChangedEventArgs e)
        {

            var data = (sender as ListView).SelectedItem as Data;
            var id = data.Id;

            if (id == "1") Frame.Navigate(typeof(TransferPage));
            if (id == "2") Frame.Navigate(typeof(ChatPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SlideIn.Begin();
        }
    }
}
