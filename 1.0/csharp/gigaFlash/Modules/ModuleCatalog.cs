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
            mInstance = this; 
        }
        
        private ModuleCatalog mInstance;

        public ModuleCatalog Instance
        {
            get
            {
                if (mInstance != null)
                    return mInstance;
                else
                    return new ModuleCatalog(); 
            }
        }
        #endregion

        #region Public Methods 
        public void Register<T>(T pInstance)
        {
            if (!mCatalog.ContainsKey(typeof(T)))
            {
                mCatalog.Add(typeof(T), pInstance); 
            }
        }

        public T Get<T>()
        {
            if (mCatalog.ContainsKey(typeof(T)))
            {
                return (T)mCatalog[typeof(T)];
            }
            else
                return default(T); 
        }
        #endregion

        #region Members / Properties
        protected Dictionary<Type, Object> mCatalog = new Dictionary<Type, object>();
        #endregion 
    }
}
