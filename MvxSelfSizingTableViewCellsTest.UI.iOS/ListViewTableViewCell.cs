using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvxSelfSizingTableViewCellsTest.Core;
using UIKit;

namespace MvxSelfSizingTableViewCellsTest.UI.iOS
{
    public partial class ListViewTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString ("ListViewTableViewCell");
        public static readonly UINib Nib;

        static ListViewTableViewCell ()
        {
            Nib = UINib.FromName ("ListViewTableViewCell", NSBundle.MainBundle);
        }

        protected ListViewTableViewCell (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }


        public string CustomTitle {
            get {
                return CustomTitleLabel.Text;
            }
        }


        public override void AwakeFromNib ()
        {
            base.AwakeFromNib ();

            this.DelayBind (() => {
                var bindingSet = this.CreateBindingSet<ListViewTableViewCell, ListEntryViewItem> ();
                bindingSet.Bind (CustomTitleLabel).To (vi => vi.Title);
                bindingSet.Apply ();
            });
        }
    }
}
