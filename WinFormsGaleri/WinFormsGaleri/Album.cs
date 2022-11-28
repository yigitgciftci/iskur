using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGaleri
{
    internal class Album
    {
        public string AlbumName { get; set; }
        public string Descripiton { get; set; }
        public string ImagePath { get; set; }
        public override string ToString()
        {
            return $"{AlbumName}|{Descripiton}";
        }
    }
}
