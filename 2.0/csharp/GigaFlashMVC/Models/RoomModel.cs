using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigaFlashMVC.Models
{
    public class RoomModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<LightModel> Lights { get; set; }

        public LightSetting RoomSetting { get; set; } 
    }
}