using MyMusicLibrary.DataModel;
using MyMusicLibrary.View;
using MyMusicLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyMusicLibrary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Song> songs;
        public List<ListViewItem> listViewItems;

        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(AllSongsPage));

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void MenuItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MenuItemsListView menuItemsListViewItem = sender as MenuItemsListView;
            if (menuItemsListViewItem != null)
            {
                switch (menuItemsListViewItem.Name)
                {
                    case "Find":
                        MyFrame.Navigate(typeof(AllSongsPage));
                        break;

                    case "Add":
                        MyFrame.Navigate(typeof(PlayListPage));
                        break;

                    default:
                        break;
                }
                MySplitView.IsPaneOpen = false;
            }
        }
    }
}
