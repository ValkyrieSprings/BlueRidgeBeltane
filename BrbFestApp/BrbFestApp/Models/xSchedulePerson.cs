using System;
using System.Collections.Generic;
using System.Text;

namespace BrbFestApp.Models
{
    public class xScheduleItem_Person
    {
        public int Id { get;              set; }
        public int  PersonId       { get; set; }
        public int  ScheduleItemId { get; set; }
        public bool IsPrimary      { get; set; }

    }

    public class xScheduleItem_Persons
    {
        public xScheduleItem_Person[] All { get; set; }
    }
}
