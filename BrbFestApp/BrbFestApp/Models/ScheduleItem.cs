using System;
using System.Collections.Generic;
using System.Text;

namespace BrbFestApp.Models
{
    public class ScheduleItem
    {
        public int Id { get;                    set; }
        public string   Title            { get; set; }
        public string   ShortDescription { get; set; }
        public string   FullDescription  { get; set; }
        public DateTime StartDateTime    { get; set; }
        public DateTime EndDateTime      { get; set; }
        public string   ImageFile        { get; set; }
        public string   ItemTypeName     { get; set; }
    }

    public class ScheduleItems
    {
        public ScheduleItem[] All { get; set; }
    }
}


