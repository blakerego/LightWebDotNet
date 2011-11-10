using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigaFlashMVC.Models;

namespace GigaFlashMVC.Controllers
{
    public class PulseController : Controller
    {
        //
        // GET: /Pulse
        public ActionResult Index()
        {
            var model = mModel.PulseSettings; 
            //PulseSetting setting1 = new PulseSetting();
            //setting1.ID = 123456;
            //setting1.Speed = 5; 
            //setting1.
            //mModel.PulseSettings.Add(setting1);
            return View();
        }


        #region Members / Fields 
        protected PulseDB mModel = new PulseDB(); 
        #endregion 
    }
}
