using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public class LightSelectorFactory : LightModuleFactoryBase<LightSelectorPresenter>
    {
        public override LightSelectorPresenter Create(ModuleOptions pModuleType)
        {
            LightState s = new LightState();
            LightSelector view = new LightSelector(); 
            return new LightSelectorPresenter(view, s); 
        }
    }
}
