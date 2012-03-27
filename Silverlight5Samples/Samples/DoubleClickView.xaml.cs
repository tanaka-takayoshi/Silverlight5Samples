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

namespace Silverlight5Samples.Samples
{
    public partial class DoubleClickView : UserControl
    {
        public DoubleClickView()
        {
            InitializeComponent();

            border2.DataContext = new MyViewModel();
        }

        private void button1_ouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text = e.ClickCount.ToString();
        }
    }

    public class MyViewModel
    {
        public void OnDoubleClicked()
        {
            MessageBox.Show("DoubelClicked");
        }
    }
}
