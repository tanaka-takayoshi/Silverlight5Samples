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
    public partial class ItemSearchView : UserControl
    {
        public ItemSearchView()
        {
            InitializeComponent();

            comboBox1.ItemsSource = ItemViewModel.GetItems();
            listBox1.ItemsSource = ItemViewModel.GetItems();
        }
    }

    public class ItemViewModel
    {
        public static IEnumerable<ItemViewModel> GetItems()
        {
            return new []
            {
                new ItemViewModel(){Name="A", Description="O"},
                new ItemViewModel(){Name="B", Description="P"},
                new ItemViewModel(){Name="C", Description="Q"},
                new ItemViewModel(){Name="D", Description="R"},
                new ItemViewModel(){Name="E", Description="S"},
                new ItemViewModel(){Name="F", Description="T"},
                new ItemViewModel(){Name="G", Description="U"},
                new ItemViewModel(){Name="H", Description="V"},
                new ItemViewModel(){Name="I", Description="W"},
            };
        }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
