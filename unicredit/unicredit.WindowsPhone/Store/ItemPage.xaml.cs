using System;
using unicredit.Common;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace unicredit.Store
{

    public sealed partial class ItemPage : Page
    {
        public ItemPage()
        {
            this.InitializeComponent();
            var helper = new NavigationHelper(this);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            var parameter = e.Parameter as string;
            string id = parameter;

            box_image.Source = new BitmapImage(new Uri("ms-appx:///Assets/Store/store_" + id + ".png"));

            if (id == "1")
            {
                box_item_list.Items.Add(new Data() { Name = "Articolo", Info = "Nokia Lumia 930" });
                box_item_list.Items.Add(new Data() { Name = "Fornitore", Info = "Unicredit" });
                box_item_list.Items.Add(new Data() { Name = "Spedizione", Info = "2 giorni" });
                box_item_list.Items.Add(new Data() { Name = "Prezzo", Info = "400€" });
            }

            if (id == "2")
            {
                box_item_list.Items.Add(new Data() { Name = "Articolo", Info = "Adobe CS6" });
                box_item_list.Items.Add(new Data() { Name = "Fornitore", Info = "Adobe" });
                box_item_list.Items.Add(new Data() { Name = "Spedizione", Info = "2 giorni" });
                box_item_list.Items.Add(new Data() { Name = "Prezzo", Info = "25€/mese" });
            }

            if (id == "3")
            {
                box_item_list.Items.Add(new Data() { Name = "Articolo", Info = "Surface 3 - 20%" });
                box_item_list.Items.Add(new Data() { Name = "Fornitore", Info = "Amazon" });
                box_item_list.Items.Add(new Data() { Name = "Spedizione", Info = "1 giorno" });
                box_item_list.Items.Add(new Data() { Name = "Prezzo", Info = "800€" });
            }

            box_action_list.Items.Add(new Data() { Name = "Acquista articolo", Info = "$" });
            box_action_list.Items.Add(new Data() { Name = "Condividi articolo", Info = "" });

            ItemAnimation.Begin();
        }
    }
}
