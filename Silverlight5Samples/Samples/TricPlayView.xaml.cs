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
    public partial class TricPlayView : UserControl
    {
        public TricPlayView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Position = TimeSpan.FromTicks(0);
            slider1.Value = 1;
            mediaElement1.Play();
        }
    }
}
