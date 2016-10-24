using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AudioBook
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            coverArt.Source = new BitmapImage(new Uri("ms-appx:///Assets/Images/The_Fifth_Season.jpg"));
            mpe.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/Audio/Terra_in_Black.mp3"));
        }

        private async void nowPlaying_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("You clicked Now Playing.");
            await dialog.ShowAsync();
        }

        private async void library_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("You clicked Library.");
            await dialog.ShowAsync();
        }

        private async void details_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("You clicked Details.");
            await dialog.ShowAsync();
        }

        private async void stats_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("You clicked Stats.");
            await dialog.ShowAsync();
        }

        private async void about_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("You clicked About.");
            await dialog.ShowAsync();
        }

        private async void settings_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("You clicked Settings.");
            await dialog.ShowAsync();
        }
    }
}
