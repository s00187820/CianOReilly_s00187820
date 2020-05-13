using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CianOReilly_s00187820
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Phone> phones = new List<Phone>();

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //add names to listbox
            Phone p1 = new Phone() { Name = "Samsung S20", OperatingSystem = "/images/android.png" };
            Phone p2 = new Phone() { Name = "IPhone 11", OperatingSystem = "/images/apple.png" };

            phones.Add(p1);
            phones.Add(p2);

            lbxPhoneNames.ItemsSource = phones;

        }

        private void LbxPhoneNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if(selectedPhone != null)
            //{
            //    string phoneCost = $"Cost >> {selectedPhone.Price:C}";
            //    tblkPrice.Text = phoneCost;

            //    image.Source = new BitmapImage(new Uri($"{selectedPhone.Phone_Image}", UriKind.Relative));
            //}
        }
    }
}
