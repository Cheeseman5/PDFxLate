using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PDFxLate.Utils;

namespace PDFxLate
{
    public static class PDFxLate
    {

        public static IEnumerable<Document> SplitDocument(Document doc, int splitInterval)
        {
            if(doc == null || splitInterval <= 0)
            {
                throw new ArgumentException();
            }
            var returnList = new List<Document>();
            while(doc.PageCount >= splitInterval)
            {
                var newDoc = new Document();
                
                if (doc.PageCount >= splitInterval)
                {
                    newDoc.DocumentName = doc.DocumentName;
                    returnList.Add(newDoc);
                }
                else
                {
                    newDoc.Pages = doc.Pages.Take(splitInterval) as ObservableCollection<Page>;
                    doc.Pages.RemoveFirst(splitInterval);
                }
            }
            return returnList;
        }
        public static void MovePageToDocument(Page page, Document source, Document target)
        {
            if(page == null)
            {
                throw new ArgumentNullException("page");
            }
            if(source == null || source.Pages == null)
            {
                throw new ArgumentNullException("source");
            }
            if(target == null || target.Pages == null)
            {
                throw new ArgumentNullException("target");
            }
            if(!source.Pages.Contains(page))
            {
                throw new KeyNotFoundException($"{page} not found in 'source' Document");
            }

            source.Pages.Remove(page);
            target.Pages.Add(page);
        }
        public static void CopyDocument(Document source, Document target) 
        {
            if(source == null)
            {
                throw new ArgumentNullException("source");
            }
            if(target == null)
            {
                throw new ArgumentNullException("target");
            }

            foreach(Page page in source.Pages)
            {
                target.Pages.Add(page);
            }
        }
    }
}
