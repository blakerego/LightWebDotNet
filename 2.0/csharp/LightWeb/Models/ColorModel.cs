using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LightWeb.Models
{
    public class ColorModel
    {
        public int ID { get; set; }

        public string Name { get; set; } 

        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; } 
    }
}