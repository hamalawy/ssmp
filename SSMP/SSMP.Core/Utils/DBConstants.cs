using System;
using System.Collections.Generic;
using System.Text;

namespace SSMP.Core.Utils
{
    public class DBConstants
    {
        public static string ASC = "ASC";
        public static string DESC = "DESC";
        public static string ID = "ID";
        public class User
        {
            public static int ACTIVE = 1;
            public static int LOCK = 0;
        }
        public class DieuKienTimKiemValue
        {
            public const int Bang = 0;
            public const int NhoHonHoacBang = 1;
            public const int LonHonHoacBang = 2;
            public const int TrongKhoang = 3;
        }
    }
}
