using System;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;


namespace Acr.MvvmCross.Plugins.ExternalApp.WinPhone {

    public class Plugin : IMvxPlugin {

        public void Load() {
            Mvx.RegisterSingleton<IExternalAppService>(new WinPhoneExternalAppService());
        }
    }
}