using System;
using System.Collections.Generic;
using System.Text;

namespace SSMP
{
    public class Constants
    {
        public static string ERROR = "Báo lỗi";
        public static string INFO = "Thông báo";
        public static string CONFIG_FILE = "Config.dat";
        public static string DATETIME_FORMAT = "dd/MM/yyyy";
        public class MODE
        {
            public const int READONLY = 0;
            public const int ADD = 1;
            public const int UPDATE = 2;
        }
    }    
}
