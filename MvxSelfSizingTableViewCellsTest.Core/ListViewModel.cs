using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace MvxSelfSizingTableViewCellsTest.Core
{
    public class ListViewModel : MvxViewModel
    {

        private IList<ListEntryViewItem> _items;


        public override void Start ()
        {
            base.Start ();

            var random = new Random ();

            var items = new List<ListEntryViewItem> ();
            for (int i = 0; i < 100; i++) {
                var numberOfLines = 1 + random.Next (4);
                var title = CreateTitleWithNumberOfLines (numberOfLines);
                items.Add (new ListEntryViewItem { Title = title });
            }
            Items = items;
        }


        public IList<ListEntryViewItem> Items {
            get {
                return _items;
            }
            set {
                _items = value;
                RaisePropertyChanged ();
            }
        }


        private string CreateTitleWithNumberOfLines (int numberOfLines)
        {
            var result = "";
            for (int i = 0; i < numberOfLines; i++) {
                if (i == 0) {
                    result += string.Format ("{0} lines in total", numberOfLines);
                } else {
                    result += string.Format ("* line {0}", i + 1);
                }

                if (i < numberOfLines - 1) {
                    result += "\n";
                }
            }
            return result;
        }
    }
}

