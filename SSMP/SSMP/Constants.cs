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

        public class DieuKienTimKiem
        {
            public DieuKienTimKiem(string text, int value)
            {
                this.Text = text;
                this.Value = value;
            }

            private string text;

            public string Text
            {
                get { return text; }
                set { text = value; }
            }
            private int value;

            public int Value
            {
                get { return this.value; }
                set { this.value = value; }
            }
        }

        public static List<DieuKienTimKiem> GetListDieuKien()
        {
            List<DieuKienTimKiem> list = new List<DieuKienTimKiem>();

            list.Add(new DieuKienTimKiem("Bằng", 0));
            list.Add(new DieuKienTimKiem("Nhỏ hơn hoặc bằng", 1));
            list.Add(new DieuKienTimKiem("Lớn hơn hoặc bằng", 2));
            list.Add(new DieuKienTimKiem("Trong khoảng", 3));

            return list;
        }
    }    
}
