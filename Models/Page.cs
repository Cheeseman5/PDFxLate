using System.Windows.Media.Imaging;

namespace Models
{
    public class Page
    {
        public int Id { get; set; }
        public double Scale { get; set; }
        public BitmapImage Image { get; set; }
        public string DocumentName { get; set; }
        public int PageNumber { get; set; }
        public float Rotation { get; set; }
    }
}
