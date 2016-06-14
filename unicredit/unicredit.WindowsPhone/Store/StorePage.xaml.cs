using System;
using unicredit.Common;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace unicredit.Store
{

    public sealed partial class StorePage : Page
    {

        int _index;

        public StorePage()
        {
            this.InitializeComponent();
            var helper = new NavigationHelper(this);

            _timer.Tick += (timer_Tick);
            _timer.Start();
        }

        private readonly DispatcherTimer _timer = new DispatcherTimer
        {
            Interval = new TimeSpan(0, 0, 3)
        };

        private void timer_Tick(object sender, object e)
        {
            box_pivot.SelectedItem = box_pivot.Items[_index];
            if (_index >= box_pivot.Items.Count - 1)
            {
                _index = 0;
            }
            else
            {
                _index++;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            box_store_list.Items.Add(new Data() { Id = "1", Image = "/Assets/Store/store_1.png", Name = "Nokia Lumia 930", Info = "400€" });
            box_store_list.Items.Add(new Data() { Id = "2", Image = "/Assets/Store/store_2.png", Name = "Adobe CS6", Info = "25€/mese" });
            box_store_list.Items.Add(new Data() { Id = "3", Image = "/Assets/Store/store_3.png", Name = "Surface 3 - 20%", Info = "800€" });
        }

        private void View_Item(object sender, SelectionChangedEventArgs e)
        {
            Data data = (sender as ListView).SelectedItem as Data;
            string id = data.Id;

            Frame.Navigate(typeof(ItemPage), id);
        }

        private void Box_pivot_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box_pivot.SelectedIndex != -1 && box_pivot.SelectedItem != null)
            {
                _index = box_pivot.Items.IndexOf(box_pivot.SelectedItem);
            }
        }
    }
}
