using System;
using System.Collections.Generic;
using System.Text;

namespace BrbFestApp.Models
{
    public class Person
    {
        public int Id { get;              set; }
        public string Name         { get; set; }
        public string Bio          { get; set; }
        public string ImageFile    { get; set; }
        public string ItemTypeName { get; set; }
    }

    public class Persons
    {
        public Person[] All { get; set; }
    }
}
