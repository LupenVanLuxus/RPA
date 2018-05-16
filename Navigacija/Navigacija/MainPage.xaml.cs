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

namespace Navigacija
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            mojFrame.Navigate(typeof(Page1));
        }

        private void btnDomov_Click(object sender, RoutedEventArgs e)
        {
            mojFrame.Navigate(typeof(Page1));
        }

        private void btnNazaj_Click(object sender, RoutedEventArgs e)
        {
            if (mojFrame.CanGoBack)
                mojFrame.GoBack();
        }

        private void btnNaprej_Click(object sender, RoutedEventArgs e)
        {
            if (mojFrame.CanGoForward)
                mojFrame.GoForward();
        }

        private void btnNaRoot_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }
    }
}
