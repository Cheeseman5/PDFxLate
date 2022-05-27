using System;
using System.Collections.ObjectModel;

namespace PDFxLate.Utils
{
    public static class Extentions
    {
        public static void RemoveFirst<T>(this ObservableCollection<T> list, int removeCount)
        {
            if(list == null)
            {
                throw new ArgumentNullException("list");
            }
            if(removeCount <= 0)
            {
                throw new ArgumentOutOfRangeException("removeCount");
            }

            for(int i=0;i<removeCount; i++)
            {
                list.RemoveAt(0);
            }
        }
    }
}
