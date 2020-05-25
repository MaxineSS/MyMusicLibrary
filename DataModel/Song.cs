using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyMusicLibrary.DataModel
{
    public enum SongCategory
    {
        Acoustic,
        Cinematic,
        Groove,
        Jazz,
        Others,
        Relax,
        
    }

    public class Song
    {


        public string Name { get; set; }
        public SongCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public ICommand Command { get; set; }


        // Custom constuctor - allocate memory
        public Song(string name, SongCategory category)
        {
          
            Name = name;
            Category = category;
 
            AudioFile = $"/Assets/Audio/{category}/{name}.wav";
            ImageFile = $"/Assets/Images/{category}/{name}.png";

        }


    }
}
