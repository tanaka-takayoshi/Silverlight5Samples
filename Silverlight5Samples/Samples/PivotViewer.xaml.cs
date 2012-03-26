using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Controls.Pivot;
using System.Windows.Data;

namespace Silverlight5Samples.Samples
{
    public partial class PivotViewer : UserControl
    {
        public PivotViewer()
        {
            InitializeComponent();

            pivotViewer1.ItemsSource = DemoItem.BuildData();

            pivotViewer1.ItemTemplates = new PivotViewerItemTemplateCollection()
                    {
                        (PivotViewerItemTemplate) Resources["DemoTemplate"]
                    };
        }
    }
}
