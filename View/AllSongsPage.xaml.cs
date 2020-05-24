using MyMusicLibrary.DataModel;
using MyMusicLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
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

namespace MyMusicLibrary.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AllSongsPage : Page
    {

        public ObservableCollection<Song> songs;
        public ObservableCollection<PlayList> playLists;
        string p;

        public AllSongsPage()
        {

            this.InitializeComponent();
            songs = new ObservableCollection<Song>();
            playLists = new ObservableCollection<PlayList>();
            PlayListViewModel.GetAllPlayList(ref playLists);
            SongViewModel.GetAllSong(songs);

        }
        private void SoundListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var sound = (Song)e.ClickedItem;
            MyMediaElement.Source = new Uri(this.BaseUri, sound.AudioFile);
        }


        private void ListViewSwipeContainer_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Mouse || e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
            {
                VisualStateManager.GoToState(sender as Control, "HoverButtonsShown", true);
            }
            var test = e.Pointer.GetType();

        }

        private void ListViewSwipeContainer_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(sender as Control, "HoverButtonsHidden", true);
        }

        private async void MenuAddPlaylist_Click(object sender, RoutedEventArgs e)
        {
            var parent = VisualTreeHelper.GetParent(this);
            while (!(parent is UserControl))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            ContentDialog1 ct = new ContentDialog1();
            var result = await ct.ShowAsync();


            if (result == ContentDialogResult.Primary)
            {
                var text = ct.Text;

            }

            else
            {
                ct.Text = " ";
                ct.Hide();
            }
            p = ct.Text;


            if (p != " ")
            {
                PlayList UP = new PlayList(p);
                PlayListViewModel.AddPlayList(UP);
            }
        }

        private void HoverButton_Click(object sender, RoutedEventArgs e)
        {

            var flyoutMenu1 = new MenuFlyoutItem();
            flyoutMenu1.Text = "Create Playlist";
            flyoutMenu1.Click += MenuAddPlaylist_Click;
            MenuFlyoutSeparator seperator = new MenuFlyoutSeparator();
            var flyoutMenu2 = new MenuFlyoutItem();
            flyoutMenu2.Text = "Add To >";
            flyoutMenu2.Click += FlyoutMenu2_Click;

            var flyout = new MenuFlyout();
            flyout.Items.Add(flyoutMenu1);

            flyout.Items.Add(flyoutMenu2);

            foreach (PlayList playlist in playLists)
            {
                var flyoutmenu = new MenuFlyoutItem();
                flyoutmenu.Text = playlist.Name;
                flyoutmenu.Click += MenuFlyoutItem_Click;
                flyout.Items.Add(flyoutmenu);
            }
            var button = (Button)sender;
            button.Flyout = flyout;
        }

        private void FlyoutMenu2_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            if (SoundListView.SelectedItem != null)
            {
                var song = (Song)SoundListView.SelectedItem;
                MenuFlyoutItem selectedItem = sender as MenuFlyoutItem;

                PlayListViewModel.AddSongToPlayList(song, selectedItem.Text.ToString());
            }

        }

    }
}