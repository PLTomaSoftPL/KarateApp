using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KarateApp.Models
{
    public class News
    {
        public string Tytul { get; set; }
        public string Tresc { get; set; }
        public DateTime Data { get; set; }
        
        public void NewsList(string tytul, string tresc, DateTime data)
        {
            Tytul = tytul;
            Tresc = tresc;
            Data = data;
             
        }
    }
}