using System;
using System.Collections.Generic;
using System.Text;

namespace PM2E1201710040168.Models
{
    public class Item
    {
        //[PrimaryKey, AutoIncrement]
        public String Id { get; set; }

        //[MaxLength(50)]
        public String Text { get; set; }

        //[MaxLength(50)]
        public String Description { get; set; }
    }
}