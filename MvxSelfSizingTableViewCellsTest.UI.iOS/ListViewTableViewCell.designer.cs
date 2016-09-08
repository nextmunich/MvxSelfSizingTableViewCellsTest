// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvxSelfSizingTableViewCellsTest.UI.iOS
{
	[Register ("ListViewTableViewCell")]
	partial class ListViewTableViewCell
	{
		[Outlet]
		UIKit.UILabel CustomTitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CustomTitleLabel != null) {
				CustomTitleLabel.Dispose ();
				CustomTitleLabel = null;
			}
		}
	}
}
