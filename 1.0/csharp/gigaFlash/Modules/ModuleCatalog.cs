using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public class ModuleCatalog
    {
        #region Singleton
        private ModuleCatalog()
        {
            sInstance = this; 
        }
        
        private static ModuleCatalog sInstance;

        public static ModuleCatalog Instance
        {
            get
            {
                if (sInstance != null)
                    return sInstance;
                else
                    return new ModuleCatalog(); 
            }
        }
        #endregion

        #region Public Methods 
        public void Add(ModuleOptions pModuleType, Object pInstance)
        {
            if (!mCatalog.ContainsKey(pModuleType))
            {
                mCatalog.Add(pModuleType, pInstance); 
            }
        }

        public Object Get(ModuleOptions pModuleType)
        {
            if (mCatalog.ContainsKey(pModuleType))
            {
                return mCatalog[pModuleType];
            }
            else
                return null; 
        }
        #endregion

        #region Members / Properties
        protected Dictionary<ModuleOptions, Object> mCatalog = new Dictionary<ModuleOptions, object>();
        #endregion 
    }
}
