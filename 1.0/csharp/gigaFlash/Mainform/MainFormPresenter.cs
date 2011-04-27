using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Modules;
using System.Windows.Forms;

namespace gigaFlash.Mainform
{
    public class MainFormPresenter
    {
        #region Constructor 
        public MainFormPresenter(IMainformView pView, LightState pState)
        {
            mView = pView;
            mState = pState; 
            mView.LightSelectorClicked += new gigaFlash.Delegates.VoidDelegate(OnLightSelectorClicked);
            mView.SnakeModuleClicked += new gigaFlash.Delegates.VoidDelegate(OnSnakeModuleClicked);
            mView.AmpSineClicked += new gigaFlash.Delegates.VoidDelegate(OnAmpSineClicked);
            mView.ThunderClicked += new gigaFlash.Delegates.VoidDelegate(OnThunderClicked);
        }
        #endregion 

        #region Handlers 
        protected virtual void OnLightSelectorClicked()
        {
            GetPresenter<LightSelectorPresenter, LightSelectorFactory>().ShowUI(); 
        }

        protected virtual void OnSnakeModuleClicked()
        {
            GetPresenter<SnakePresenter, SnakePresFactory>().ShowUI(); 
        }

        protected virtual void OnAmpSineClicked()
        {
            GetPresenter<AmpSinePresenter, AmpSinePresFactory>().ShowUI(); 
        }

        protected virtual void OnThunderClicked()
        {
            GetPresenter<ThunderPresenter, ThunderPresenterFactory>().ShowUI();  
        }
        #endregion 

        #region Public Methods
        public Pres GetPresenter<Pres, Factory>()
            where Pres : LightModulePresenterBase
            where Factory : LightModuleFactoryBase<Pres>
        {
            Factory factory = Activator.CreateInstance(typeof(Factory)) as Factory;
            return factory.Create(mState);
        }
        #endregion 

        #region Members / Properties
        protected IMainformView mView;

        protected LightState mState; 

        #endregion
    }
}
