using Models;
using System.Collections.ObjectModel;

namespace PDFxLate
{
    public static class Factory
    {
        private static int _currentPageId;

        public static Page NewPage()
        {
            var page = new Page
            {
                Id = ++_currentPageId
            };

            return page;
        }

        public static Document NewDocument()
        {
            return new Document
            {
                Pages = new ObservableCollection<Page>()
            };
        }
    }
}
