﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAnalytics.Models.BookmarkAPI;

namespace WebAnalytics.Models.LogBookmarks
{
    public class LogFileBookmark:Bookmark
    {
        private string format = "yyyy-MM-dd HH:mm:ss";
        public string FilePath { get; set; }
        public DateTime StartDateTime { get; set; }
        public long Location { get; set; }

        //in this case Mark will return a long which denotes the byte location in the file
        public object Mark
        {
            get { throw new NotImplementedException(); }
        }

        public string BookmarkDescription { get { return StartDateTime.ToString(format) + " " + FilePath + " " + Convert.ToString(Location); } }
    }
}