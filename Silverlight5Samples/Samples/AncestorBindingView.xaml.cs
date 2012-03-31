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
    public partial class AncestorBindingView : UserControl
    {
        public AncestorBindingView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = new[]
            {
                new Person(){FirstName="A", LastName="O", Address=""},
                new Person(){FirstName="B", LastName="P", Address=""},
                new Person(){FirstName="C", LastName="Q", Address=""},
                new Person(){FirstName="D", LastName="R", Address=""},
                new Person(){FirstName="E", LastName="S", Address=""},
                new Person(){FirstName="F", LastName="T", Address=""},

            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
