using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace LightWeb.Models
{
    public class User
    {
        public int ID { get; set;  }

        public string Name { get; set; }

        public ICollection<ColorModel> Colors { get; set; }

        public ICollection<RoomModel> Rooms { get; set; }         
    }
}