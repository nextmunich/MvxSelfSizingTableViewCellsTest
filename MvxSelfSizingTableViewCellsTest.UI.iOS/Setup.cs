using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform;
using MvxSelfSizingTableViewCellsTest.Core;
using UIKit;

namespace MvxSelfSizingTableViewCellsTest.UI.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup (IMvxApplicationDelegate applicationDelegate, UIWindow window) : base (applicationDelegate, window)
        {
        }


        protected override MvvmCross.Core.ViewModels.IMvxApplication CreateApp ()
        {
            return new App ();
        }

        protected override void InitializeLastChance ()
        {
            base.InitializeLastChance ();

            // If this line is uncommented, self-sizing cells work. If it is not
            // uncommented, the MvxTaskBasedBindingContext is used which does not
            // update the cells bound widgets before GetCell() returns. Thus, the
            // cell height calculation is performed on outdated content, leading to
            // incorrect heights.
            //Mvx.RegisterType<IMvxBindingContext, MvxBindingContext> ();
        }

    }
}

