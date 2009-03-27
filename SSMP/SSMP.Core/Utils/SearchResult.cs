using System;
using System.Collections.Generic;
using System.Text;

namespace SSMP.Core.Utils
{
    public class SearchResult<T>
    {
        private List<T> _SearchList;
        private System.Int32 _SearchSize;

        public List<T> SearchList
        {
            get { return _SearchList; }
            set { _SearchList = value; }
        }

        public System.Int32 SearchSize
        {
            get { return _SearchSize; }
            set { _SearchSize = value; }
        }
    }
}
