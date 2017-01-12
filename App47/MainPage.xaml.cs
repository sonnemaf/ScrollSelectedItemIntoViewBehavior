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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App47 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {

        public MainPage() {
            this.InitializeComponent();
        }

        private void ButtonFirst_Click(object sender, RoutedEventArgs e) {
            listViewProducts.SelectedIndex = 0;
        }

        private void ButtonMiddle_Click(object sender, RoutedEventArgs e) {
            listViewProducts.SelectedIndex = (listViewProducts.Items.Count - 1) / 2;
        }

        private void ButtonLast_Click(object sender, RoutedEventArgs e) {
            listViewProducts.SelectedIndex = listViewProducts.Items.Count - 1;

        }
    }
}
