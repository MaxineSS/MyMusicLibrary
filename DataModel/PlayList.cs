using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyMusicLibrary.DataModel
{
    public class PlayList
    {

        public List<Song> SongList;

        string CoverImagePath;
        public ICommand Command { get; set; }
        public string Name { get; set;  }

        public PlayList()
        {
            Name = null;
            SongList = new List<Song>();
        }
        public PlayList(string name)
        {
            Name = name;
            SongList = new List<Song>();
        }

        public PlayList(string name, string coverimagepath)
        {
            Name = name;
            SongList = new List<Song>();
            CoverImagePath = coverimagepath;
        }

        public string GetName()
        {
            return Name;
        }

    }
}
