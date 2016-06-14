using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace unicredit
{
    class Data
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Total { get; set; }
        public string Color { get; set; }
        public string Date { get; set; }
    }

    public class ListItemClass
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Total { get; set; }
        public string Url { get; set; }
        public Uri Image { get; set; }
    }

}
