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
using Java.Lang;
using KarateApp.Models;

namespace KarateApp.Adapters
{
    public class NewsListAdapter : BaseAdapter<News>
    {
        private List<News> news;
        private Activity parent;


        public NewsListAdapter(List<News> news, Activity parent)
        {
            this.news = news;
            this.parent = parent;
        }

        public override News this[int position]
        {
            get
            {
                return news[position];
            }
        }

        public override int Count => news.Count;


        public override Java.Lang.Object GetItem(int position)
        {

            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            if(convertView==null)
            {
                convertView = this.parent.LayoutInflater.Inflate(Resource.Layout.view_newsList, null);
            }

            return convertView;
        }
    }
}