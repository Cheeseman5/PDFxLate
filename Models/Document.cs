using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media.Imaging;

namespace Models
{
    public class Document
    {
        public ObservableCollection<Page> Pages { get; set; }
        public BitmapImage Image => Pages?.FirstOrDefault()?.Image;
        public string DocumentName { get; set; }
        public int PageCount => (int)Pages?.Count;
    }
}
