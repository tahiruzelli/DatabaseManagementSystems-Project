using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1vtys
{
   static class OgrenciNo
    {
        private static string _ogrenciNo ="";
        private static string _bolumNo = "";
        public static string ogrenciNo
        {
            get { return _ogrenciNo; }
            set { _ogrenciNo = value; }
        }
        
        public static string bolumNo
        {
            get { return _bolumNo; }
            set { _bolumNo = value; }
        }
    }
}
