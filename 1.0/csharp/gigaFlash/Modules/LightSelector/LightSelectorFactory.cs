using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public class LightSelectorFactory : LightModuleFactoryBase<LightSelectorPresenter>
    {
        public override LightSelectorPresenter Create(ModuleOptions pModuleType, LightState pState)
        {
            IViewFactory<ILightSelectorView> viewFactory 
                = (IViewFactory<ILightSelectorView>) 
                ModuleCatalog.Instance.Get(ModuleOptions.LightSelector);
            return new LightSelectorPresenter(viewFactory.Create(), pState); 
        }
    }
}
