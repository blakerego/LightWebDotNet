using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public interface ILightModuleFactoryBase
    {
        LightModulePresenterBase CreateBase(ModuleOptions pModuleType); 
    }

    public abstract class LightModuleFactoryBase<T> : ILightModuleFactoryBase
        where T : LightModulePresenterBase
    {
        public abstract T Create(ModuleOptions pModuleType);

        public LightModulePresenterBase CreateBase(ModuleOptions pModuleType)
        {
            return Create(pModuleType); 
        }
    }
}
