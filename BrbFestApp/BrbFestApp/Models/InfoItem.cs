using System;
using System.Collections.Generic;
using System.Text;

namespace BrbFestApp.Models
{
    public class InfoItem
    {
        public int Id { get;            set; }
        public string Title      { get; set; }
        public string ShortDescription      { get; set; }
        public string LongDescription      { get; set; }
        public string ItemTypeName   { get; set; }
    }

    public class InfoItems
    {
        public InfoItem[] All { get; set; }
    }
}
