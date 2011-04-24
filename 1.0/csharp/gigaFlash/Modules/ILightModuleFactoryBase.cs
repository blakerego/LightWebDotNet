using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public interface ILightModuleFactoryBase
    {
        LightModulePresenterBase CreateBase(ModuleOptions pModuleType, LightState pState); 
    }

    public abstract class LightModuleFactoryBase<T> : ILightModuleFactoryBase
        where T : LightModulePresenterBase
    {
        public abstract T Create(ModuleOptions pModuleType, LightState pState);

        public LightModulePresenterBase CreateBase(ModuleOptions pModuleType, LightState pState)
        {
            return Create(pModuleType, pState); 
        }
    }
}
