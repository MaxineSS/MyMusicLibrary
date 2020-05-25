using MyMusicLibrary.DataModel;
using MyMusicLibrary.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Midi;

namespace MyMusicLibrary.ViewModel
{
    public static class PlayListViewModel
    {
        private static readonly ObservableCollection<Song> allSongs;
        private static readonly ObservableCollection<PlayList> allPlayLists;

        static PlayListViewModel()
        {
            allSongs = new ObservableCollection<Song>();
            allPlayLists = new ObservableCollection<PlayList>();
        }

        public static ObservableCollection<Song> GetAllSongs()
        {
            return allSongs;
        }

        public static void GetAllPlayList(ref ObservableCollection<PlayList> playlists)
        {
            playlists = allPlayLists;
        }
        public static void GetSongsByPlayList(ObservableCollection<Song> songs, PlayList playlist)
        {
            songs.Clear();
            List<Song> listSongs = playlist.SongList;
            listSongs.ForEach(s => songs.Add(s));
        }

        public static void AddSongToPlayList(Song newsong, string playlistName)
        {
            foreach(PlayList playlist in allPlayLists)
            {
                if (playlist.Name.Equals(playlistName))
                {
                    playlist.SongList.Add(newsong);
                }
            }
        }
        public static void DeleteSongFromPlaylist(Song song, string playlistName)
        {
            foreach (PlayList playlist in allPlayLists)
            {
                if (playlist.Name.Equals(playlistName))
                {
                    playlist.SongList.Remove(song);
                }
            }
        }
        public static void AddPlayList(PlayList newPlayList)
        {
            allPlayLists.Add(newPlayList);
        }

        public static void DeletePlayList(string nameToDelete)
        {
            PlayList objectToDelete = null;
            foreach (PlayList p in allPlayLists)
            {
                if (string.Equals(p.GetName(), nameToDelete))
                {
                    objectToDelete = p;
                    break;
                }
            }
            allPlayLists.Remove(objectToDelete);
            return;
        }


    }
}
