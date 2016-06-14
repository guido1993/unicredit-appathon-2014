using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using unicredit.Common;
using unicredit.Fund;
using unicredit.Store;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace unicredit
{

    public sealed partial class HomePage : Page
    {
        private static bool _loadedToast = false;

        public HomePage()
        {
            this.InitializeComponent();
            NavigationHelper helper = new NavigationHelper(this);
            if (!_loadedToast)
            {
                ShowToastNotification();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SlideIn.Begin();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (box_info_list.Items != null)
            {
                box_info_list.Items.Add(new Data() { Name = "Intestatario", Info = "13234.12€", Color = "Normal" });
                box_info_list.Items.Add(new Data() { Name = "c/c n.°", Info = "2193 8233 1924 7234", Color = "Normal" });
                box_info_list.Items.Add(new Data() { Name = "Saldo", Info = "2312.80€", Color = "Black" });

                box_action_personal_list.Items.Add(new Data() { Name = "Lista Acconti e Prelievi", Info = "" });
                box_action_personal_list.Items.Add(new Data() { Name = "Effettua Pagamento/Prelievo", Info = "" });

                box_action_list.Items.Add(new Data() { Id = "1", Name = "UniShare", Info = "" });
                box_action_list.Items.Add(new Data() { Id = "2", Name = "UniBuy", Info = "" });
                box_action_list.Items.Add(new Data() { Name = "Borsa e Portafoglio", Info = "$" });
            }
        }

        private void View_Page(object sender, SelectionChangedEventArgs e)
        {

            Data data = (sender as ListView).SelectedItem as Data;
            string id = data.Id;

            if (id == "1") Frame.Navigate(typeof(OverviewPage));
            if (id == "2") Frame.Navigate(typeof(StorePage));
        }

        private static void ShowToastNotification()
        {
            ToastNotificationManager.History.Clear();

            const ToastTemplateType toastTemplate = ToastTemplateType.ToastImageAndText01;
            var toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);

            // Set Text
            var toastTextElements = toastXml.GetElementsByTagName("text");
            toastTextElements[0].AppendChild(toastXml.CreateTextNode("Trovati 6 nuovi prodotti in offerta sull'Unicredit Store"));

            // Set image
            // Images must be less than 200 KB in size and smaller than 1024 x 1024 pixels.
            var toastImageAttributes = toastXml.GetElementsByTagName("image");
            ((XmlElement)toastImageAttributes[0]).SetAttribute("src", "ms-appx:///Assets/Images/unicredit_logo_original.png");
            ((XmlElement)toastImageAttributes[0]).SetAttribute("alt", "logo");

            // toast duration
            var toastNode = toastXml.SelectSingleNode("/toast");
            ((XmlElement)toastNode).SetAttribute("duration", "short");

            // toast navigation
            const string toastNavigationUriString = "#/MainPage.xaml?param1=12345";
            var toastElement = ((XmlElement)toastXml.SelectSingleNode("/toast"));
            toastElement.SetAttribute("launch", toastNavigationUriString);

            // Create the toast notification based on the XML content you've specified.
            var toast = new ToastNotification(toastXml) { SuppressPopup = true };

            // Send your toast notification.
            ToastNotificationManager.CreateToastNotifier().Show(toast);

            _loadedToast = true;
        }

    }
}
