using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMModels
{
   public class Pagination
    {
        int _currentPage;
        
        public int CurrentPage {

            get
            {
                if (_currentPage==0)
                {
                    return 1;
                }
                else
                {
                    return _currentPage;
                }

            }




            set => _currentPage = value; }

        public int RowPerPage { get; set; }

        public int TotalRows { get; set; }


        public int StartIndex { get; set; }

        public int Pages { get; set; }

        public bool IsAll { get; set; } = false;


        public void GetPages(int count)
        {
            TotalRows = count;
            if (IsAll)
            {
                RowPerPage = TotalRows;
            }
            Pages = (int)Math.Ceiling(TotalRows * 1.0 / RowPerPage);
            if (CurrentPage > Pages)
            {
                CurrentPage = 1;
            }

            StartIndex = (CurrentPage - 1) * RowPerPage;            
        }

        public List<T> GetPages<T>(List<T> ls)
        {
            TotalRows= ls.Count;

            Pages =(int)Math.Ceiling( TotalRows * 1.0 / RowPerPage);
            if(CurrentPage > Pages)
            {
                CurrentPage = 1;
            }

            StartIndex = (CurrentPage - 1) * RowPerPage;
            return ls.Skip(StartIndex).Take(RowPerPage).ToList();
        }
    }
}
