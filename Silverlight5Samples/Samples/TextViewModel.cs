using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Silverlight5Samples.Samples
{
    public class TextViewModel : INotifyPropertyChanged
    {
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                if (value == text) return;
                text = value;
                FirePropertyChanged("Text");
            }
        }

        private string text2;
        public string Text2
        {
            get { return text2; }
            set
            {
                if (value == text2) return;
                text2 = value;
                FirePropertyChanged("Text2");
            }
        }

        private void FirePropertyChanged(string propName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                changed(this, new PropertyChangedEventArgs(propName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
