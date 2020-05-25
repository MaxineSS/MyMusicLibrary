using MyMusicLibrary.DataModel;
using MyMusicLibrary.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicLibrary.ViewModel
{
    public static class SongViewModel
    {

        public static void GetAllSongs(ObservableCollection<Song> songs)
        {
            var allSongs = GetSongs();
            songs.Clear();
            allSongs.ForEach(s => songs.Add(s));
        }

        public static void GetSongsByCategory(ObservableCollection<Song> songs, SongCategory category)
        {
            var allSongs = GetSongs();
            List<Song> filteredSongs = allSongs.Where(song => song.Category == category).ToList();
            songs.Clear();
            filteredSongs.ForEach(s => songs.Add(s));
        
        }

        private static List<Song> GetSongs()
        {
            var songs = new List<Song>();
            songs.Add(new Song("A Day To Remember", SongCategory.Acoustic));
            songs.Add(new Song("Acoustic Breeze", SongCategory.Acoustic));
            songs.Add(new Song("Happiness", SongCategory.Acoustic));
            songs.Add(new Song("Smile", SongCategory.Acoustic));
            songs.Add(new Song("Sunny", SongCategory.Acoustic));
            songs.Add(new Song("Ukulele", SongCategory.Acoustic));
            songs.Add(new Song("Adventure", SongCategory.Cinematic));
            songs.Add(new Song("Better Days", SongCategory.Cinematic));
            songs.Add(new Song("Memories", SongCategory.Cinematic));
            songs.Add(new Song("Once Again", SongCategory.Cinematic));
            songs.Add(new Song("Piano Moment", SongCategory.Cinematic));
            songs.Add(new Song("Sad Day", SongCategory.Cinematic));
            songs.Add(new Song("Slowmotion", SongCategory.Cinematic));
            songs.Add(new Song("Tomorrow", SongCategory.Cinematic));
            songs.Add(new Song("Badass", SongCategory.Groove));
            songs.Add(new Song("Downtown", SongCategory.Groove));
            songs.Add(new Song("funnySong", SongCategory.Groove));
            songs.Add(new Song("RetroSoul", SongCategory.Groove));
            songs.Add(new Song("AllThat", SongCategory.Jazz));
            songs.Add(new Song("HipJazz", SongCategory.Jazz));
            songs.Add(new Song("JazzComedy", SongCategory.Jazz));
            songs.Add(new Song("JazzyFrenchy", SongCategory.Jazz));
            songs.Add(new Song("Love", SongCategory.Jazz));
            songs.Add(new Song("Romantic", SongCategory.Jazz));
            songs.Add(new Song("TheElevator", SongCategory.Jazz));
            songs.Add(new Song("TheJazzPiano", SongCategory.Jazz));
            songs.Add(new Song("TheLounge", SongCategory.Jazz));
            songs.Add(new Song("Brazil Samba", SongCategory.Others));
            songs.Add(new Song("Country Boy", SongCategory.Others));
            songs.Add(new Song("Creepy", SongCategory.Others));
            songs.Add(new Song("Little Planet", SongCategory.Others));
            songs.Add(new Song("Psychedelic", SongCategory.Others));
            songs.Add(new Song("Relaxing", SongCategory.Others));
            songs.Add(new Song("Sci-fi", SongCategory.Others));
            songs.Add(new Song("Together", SongCategory.Others));

            return songs;
        }


        internal static void GetAllSong(ObservableCollection<Song> songs)
        {
            var allSongs = GetSongs();
            songs.Clear();
            allSongs.ForEach(s => songs.Add(s));
        }
    }
}
