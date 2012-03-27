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
using System.Windows.Interactivity;
using System.Reactive.Linq;

namespace Silverlight5Samples.Triggers
{
    public class ClickTrigger : TriggerBase<UIElement>
    {
        public static readonly DependencyProperty ClickCountProperty = DependencyProperty.Register(
          "ClickCount",
          typeof(int),
          typeof(ClickTrigger),
          null);

        public int ClickCount
        {
            get { return (int)GetValue(ClickCountProperty); }
            set { SetValue(ClickCountProperty, value); }
        }

        private IDisposable dispose;

        protected override void OnAttached()
        {
            base.OnAttached();

            dispose = Observable.FromEventPattern<MouseButtonEventHandler, MouseButtonEventArgs>(
                h => h.Invoke,
                h => AssociatedObject.MouseLeftButtonDown += h,
                h => AssociatedObject.MouseLeftButtonDown -= h)
                .Where(e => e.EventArgs.ClickCount == ClickCount)
                .Subscribe(res => { InvokeActions(res); });
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            if (dispose != null) dispose.Dispose();
        }
    }
}
