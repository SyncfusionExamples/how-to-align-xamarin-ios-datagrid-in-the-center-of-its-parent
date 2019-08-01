using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Syncfusion.SfDataGrid;

namespace CenterAlignGrid
{
    public class MyViewController : UIViewController
    {
        SfDataGrid dataGrid;
        ViewModel viewModel;
        public MyViewController()
        {
            dataGrid = new SfDataGrid();
            viewModel = new ViewModel();
            dataGrid.ItemsSource = viewModel.Collection;            
            View.AddSubview(dataGrid);            
        }
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            int dataGridHeight = 400;
            int dataGridWidth = 200;
            dataGrid.Frame = new CoreGraphics.CGRect(View.Center.X - dataGridWidth / 2, View.Center.Y - dataGridHeight / 2, dataGridWidth, dataGridHeight);
        }
    }
}