using System;
using System.Collections.Generic;
using System.Text;

namespace BrbFestApp.Models
{
    public class ItemType
    {
        public int Id { get;            set; }
        public string Name      { get; set; }
    }

    public class ItemTypes
    {
        public ItemType[] All { get; set; }
    }
}