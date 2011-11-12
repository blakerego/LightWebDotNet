using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LightWeb.Models
{
    public class LightSetting
    {
        [Key]
        public string Name { get; set; }

        public ColorModel Color_Primary { get; set; }

        public ICollection<ColorModel> Colors_Secondary { get; set; }

        public int Speed { get; set; }

    }
}