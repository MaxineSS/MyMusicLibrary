using MyMusicLibrary.DataModel;
using MyMusicLibrary.View;
using MyMusicLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyMusicLibrary
{

    public sealed partial class PlaylistDetailPage : Page
    {
        string p;

        public ObservableCollection<PlayList> playlists;
      
        public PlaylistDetailPage()
        {
            this.InitializeComponent();
            playlists = new ObservableCollection<PlayList>();
            PlayListViewModel.GetAllPlayList(ref playlists);
        }

        private async void AddPlaylistButton_Click(object sender, RoutedEventArgs e)
        {

            ContentDialog1 ct = new ContentDialog1();
            var result = await ct.ShowAsync();


            if (result == ContentDialogResult.Primary)
            {
                var text = ct.Text;

            }

            else
            {
                ct.Text = " ";

            }
            p = ct.Text;


            if (p != " ")
            {
                PlayList UP = new PlayList(p);
                PlayListViewModel.AddPlayList(UP);
                PlayListViewModel.GetAllPlayList(ref playlists);

            }
        }
        public void ListViewSwipeContainer_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Mouse || e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
            {
                VisualStateManager.GoToState(sender as Control, "HoverButtonsShown", true);
            }
        }

        public void ListViewSwipeContainer_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(sender as Control, "HoverButtonsHidden", true);
        }



        public void PlayListsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var playlist = (PlayList)e.ClickedItem;
            this.Frame.Navigate(typeof(PlaylistDetailPage), playlist);
        }
    }
}
