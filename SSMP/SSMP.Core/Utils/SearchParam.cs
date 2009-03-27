using System;
using System.Collections.Generic;
using System.Text;

namespace SSMP.Core.Utils
{
    public class SearchParam
    {
        private string _SortBy;
        private string _SortDir;
        private int _Start;
        private int _Limit;

        public string SortBy
        {
            get { return _SortBy; }
            set { _SortBy = value; }
        }

        public string SortDir
        {
            get { return _SortDir; }
            set { _SortDir = value; }
        }

        public int Start
        {
            get { return _Start; }
            set { _Start = value; }
        }
        
        public int Limit
        {
            get { return _Limit; }
            set { _Limit = value; }
        }
    }
}
