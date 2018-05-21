using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            mojSplit.IsPaneOpen = !mojSplit.IsPaneOpen;
        }

        private void lstIkone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (itemDeli.IsSelected)
            {
                tbRezultat.Text = "Deli z vsemi v okolici!";
            }
            else
                if (itemPriljubljene.IsSelected)
            {
                tbRezultat.Text = "Dodano med priljubjene";
            }
        }
    }
}
