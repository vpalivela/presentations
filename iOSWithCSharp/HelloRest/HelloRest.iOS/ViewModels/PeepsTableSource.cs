using System;
using System.Linq;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using HelloRest.Models;

namespace HelloRest.iOS
{
	public class PeepsTableSource : UITableViewSource
	{
		protected List<Person> tableItems;
		protected string cellIdentifier = "PEEP_IDENTIFIER";

		public PeepsTableSource() : this(new List<Person>()){}
		public PeepsTableSource(List<Person> items)
		{
			this.tableItems = items;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return tableItems.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (this.cellIdentifier);

			// if there are no cell to reuse, create a new one
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, this.cellIdentifier);
			}

			// set the item text
			cell.TextLabel.Text = tableItems[indexPath.Row].Name;

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			tableView.DeselectRow (indexPath, true); // normal iOS behaviour is to remove the blue highlight

			var alert = new UIAlertView();
			alert.Message = string.Format("{0} tapped!", tableItems[indexPath.Row].Name);
			alert.AddButton("OK");
			alert.Show();
		}
	}
}

