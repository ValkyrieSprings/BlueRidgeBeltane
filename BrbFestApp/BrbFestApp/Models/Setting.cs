using System;
using System.Collections.Generic;
using System.Text;

namespace BrbFestApp.Models
{
    public class Setting
    {
        public int Id { get;            set; }
        public string Name      { get; set; }
        public string Value      { get; set; }
        public string Type      { get; set; }
    }

    public class Settings
    {
        public Setting[] All { get; set; }
    }
}