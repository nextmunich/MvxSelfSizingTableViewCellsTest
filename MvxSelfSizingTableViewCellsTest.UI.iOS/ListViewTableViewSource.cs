using System;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Platform;
using MvxSelfSizingTableViewCellsTest.Core;
using UIKit;

namespace MvxSelfSizingTableViewCellsTest.UI.iOS
{
    public class ListViewTableViewSource : MvxTableViewSource
    {
        public ListViewTableViewSource (UITableView tableView) : base (tableView)
        {
            tableView.RegisterNibForCellReuse (ListViewTableViewCell.Nib, ListViewTableViewCell.Key);
        }

        protected override UITableViewCell GetOrCreateCellFor (UITableView tableView, Foundation.NSIndexPath indexPath, object item)
        {
            return tableView.DequeueReusableCell (ListViewTableViewCell.Key, indexPath);
        }

        public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var cell = base.GetCell (tableView, indexPath) as ListViewTableViewCell;

            var item = cell.DataContext as ListEntryViewItem;
            var title = cell.CustomTitle;

            Mvx.Trace ("data context title: {0}; label text: {1}", item.Title, title);

            return cell;
        }
    }
}

