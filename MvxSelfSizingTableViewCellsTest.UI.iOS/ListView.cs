using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvxSelfSizingTableViewCellsTest.Core;
using UIKit;

namespace MvxSelfSizingTableViewCellsTest.UI.iOS
{
    public partial class ListView : MvxViewController
    {
        public ListView () : base ("ListView", null)
        {
        }

        public new ListViewModel ViewModel {
            get { return base.ViewModel as ListViewModel; }
            set { base.ViewModel = value; }
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            TableView.RowHeight = UITableView.AutomaticDimension;
            TableView.EstimatedRowHeight = 102;

            var tableViewSource = new ListViewTableViewSource (TableView);
            TableView.Source = tableViewSource;

            var bindingSet = this.CreateBindingSet<ListView, ListViewModel> ();
            bindingSet.Bind (tableViewSource).To (vm => vm.Items);
            bindingSet.Apply ();

        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


