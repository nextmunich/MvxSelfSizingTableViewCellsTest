using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace MvxSelfSizingTableViewCellsTest.Core
{
    public class App : MvxApplication
    {
        public App ()
        {
            Mvx.RegisterSingleton<IMvxAppStart> (new MvxAppStart<ListViewModel> ());
        }
    }
}

