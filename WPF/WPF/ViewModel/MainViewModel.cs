using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment5.Model;
using Assignment5.Command;
using System.Windows.Input;
using System.Windows;

namespace Assignment5.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private MultiMediaList list;

        private Multimedia currentItem;

        private ICommand addNewItemCommand;

        private string title;
        private string artist;
        private string genre;

        private string newTitle;
        private string newArtist;
        private string newGenre;

        private List<string> mediaTypes;
        private List<string> newMediaTypes;

        private string selectedMediaType;
        private string selectedNewMediaType;

        public MainViewModel()
        {
            list = new MultiMediaList();
            addNewItemCommand = new AddNewItemCommand(this);

            // a list of media types
            mediaTypes = new List<string>() { "CD", "DVD" };
            newMediaTypes = new List<string>() { "CD", "DVD" };
        }

        public MultiMediaList List
        {
            get
            {
                return list;
            }
            set
            {
                this.list = value;
                RaisePropertyChanged("List");
            }
        }

        public Multimedia CurrentItem
        {
            get
            {
                return currentItem;
            }
            set
            {
                this.currentItem = value;

                // show the details of the selected multimedia file
                if (currentItem != null)
                {
                    title = currentItem.getTitle();
                    artist = currentItem.getArtist();
                    genre = currentItem.getGenre();
                    selectedMediaType = currentItem.getMediaType();

                    RaisePropertyChanged("Title");
                    RaisePropertyChanged("Artist");
                    RaisePropertyChanged("Genre");
                    RaisePropertyChanged("SelectedMediaType");
                }

                RaisePropertyChanged("CurrentItem");
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                this.title = value;
                RaisePropertyChanged("Title");
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                this.artist = value;
                RaisePropertyChanged("Artist");
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                this.genre = value;
                RaisePropertyChanged("Genre");
            }
        }

        public string NewTitle
        {
            get
            {
                return newTitle;
            }
            set
            {
                this.newTitle = value;

                RaisePropertyChanged("NewTitle");
            }
        }

        public string NewArtist
        {
            get
            {
                return newArtist;
            }
            set
            {
                this.newArtist = value;

                RaisePropertyChanged("NewArtist");
            }
        }

        public string NewGenre
        {
            get
            {
                return newGenre;
            }
            set
            {
                this.newGenre = value;

                RaisePropertyChanged("NewGenre");
            }
        }

        public List<string> MediaTypes
        {
            get
            {
                return mediaTypes;
            }
            set
            {
                this.mediaTypes = value;

                RaisePropertyChanged("MediaTypes");
            }
        }

        public List<string> NewMediaTypes
        {
            get
            {
                return newMediaTypes;
            }
            set
            {
                this.newMediaTypes = value;

                RaisePropertyChanged("NewMediaTypes");
            }
        }

        public string SelectedMediaType
        {
            get
            {
                return selectedMediaType;
            }
            set
            {
                this.selectedMediaType = value;

                RaisePropertyChanged("SelectedMediaType");
            }
        }

        public string SelectedNewMediaType
        {
            get
            {
                return selectedNewMediaType;
            }
            set
            {
                this.selectedNewMediaType = value;

                RaisePropertyChanged("SelectedNewMediaType");
            }
        }

        public ICommand AddNewItemCommand
        {
            get
            {
                return addNewItemCommand;
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

        public void addNewItem()
        {
            list.Add(new Multimedia(newTitle, newArtist, newGenre, selectedNewMediaType.Equals("CD") ? Multimedia.MediaType.CD: Multimedia.MediaType.DVD));

            newTitle = newArtist = newGenre = "";

            RaisePropertyChanged("NewTitle");
            RaisePropertyChanged("NewArtist");
            RaisePropertyChanged("NewArtist");
        }
    }
}
