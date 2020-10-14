using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Model
{
    public class Multimedia : INotifyPropertyChanged
    {
        public enum MediaType
        {
            CD,
            DVD
        };

        private string _title;
        private string _artist;
        private string _genre;
        private MediaType _type;

        private string _display;

        public Multimedia(string new_title, string new_artist, string new_genre, MediaType new_type)
        {
            this._title = new_title;
            this._artist = new_artist;
            this._genre = new_genre;
            this._type = new_type;

            this._display = new_title + " " + new_artist + " " + new_genre + " " + ((new_type == MediaType.CD) ? "CD" : "DVD");

            RaisePropertyChanged("Display");
        }
       
        public string getTitle() { return _title; }
        public string getArtist() { return _artist; }
        public string getGenre() { return _genre; }

        public string getMediaType()
        {
            if (_type == MediaType.CD) return "CD";
            else
                return "DVD";
        }

        public string Display
        {
            get
            {
                return _display;
            }
            set
            {
                this._display = value;

                RaisePropertyChanged("Display");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
