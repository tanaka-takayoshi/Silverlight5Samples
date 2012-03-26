using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Silverlight5Samples.Samples
{
    public class DemoItem : INotifyPropertyChanged
    {
        public string ShortName { get; set; }

        private string _color;
        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
                NotifyProperty("Color");
            }
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                NotifyProperty("Value");
            }
        }

        private string _data1;
        public string Data1
        {
            get { return _data1; }
            set
            {
                _data1 = value;
                NotifyProperty("Data1");
            }
        }

        private DateTime _stamp;
        public DateTime Stamp
        {
            get { return _stamp; }
            set
            {
                _stamp = value;
                NotifyProperty("Stamp");
            }
        }

        public static ObservableCollection<DemoItem> BuildData()
        {
            var data = new ObservableCollection<DemoItem>();

            for (int i = 0; i < 100; i++)
            {
                var itm = new DemoItem() { ShortName = i.ToString("000") };

                var mod = i % 3;

                switch (mod)
                {
                    case 0:
                        itm.Color = "Blue";
                        break;
                    case 1:
                        itm.Color = "Red";
                        break;
                    case 2:
                        itm.Color = "Green";
                        break;
                }

                itm.Data1 = i % 2 == 0 ? "Even" : "Odd";
                itm.Stamp = DateTime.Now.AddDays(-1 * i);
                data.Add(itm);
            }

            return data;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyProperty(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                  new PropertyChangedEventArgs(propName));
        }

        #endregion

    }
}
