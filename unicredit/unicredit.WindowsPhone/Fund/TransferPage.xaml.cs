using System;
using System.Linq;
using unicredit.Common;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace unicredit.Fund
{
    public sealed partial class TransferPage : Page
    {

        public TransferPage()
        {
            this.InitializeComponent();
            NavigationHelper helper = new NavigationHelper(this);

            timer.Tick += (timer_Tick);
            timer.Start();
        }

        DispatcherTimer timer = new DispatcherTimer
        {
            Interval = new TimeSpan(0, 0, 0, 0, 100)
        };

        private void timer_Tick(object sender, object e)
        {
            var i = new Random();
            var rColor = i.Next(1, 4);
            var rPerson = i.Next(1, 4);
            var rValue = i.Next(100, 200);

            var color = "Green";
            var person = "Bruno Luca";

            if (box_transfer_list.Items.Count() <= 10)
            {
                if (rColor == 3) color = "Red";
                if (rPerson == 2) person = "Guido Magrin";
                if (rPerson == 3) person = "Luca Montanari";

                box_transfer_list.Items.Add(new Data() { Name = person, Total = rValue.ToString(), Color = color, Info = rValue + "€", Date = (box_transfer_list.Items.Count() + 1) + " giorni fa"});
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
