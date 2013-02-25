using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LightWeb.Models
{
    public class LightModel
    {
        [Key]
        public int index { get; set; }

        LightSetting Setting { get; set; }
    }
}