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
using Microsoft.Xna.Framework.Audio;

namespace Silverlight5Samples.Samples
{
    public partial class SoundEffectView : UserControl
    {
        public SoundEffectView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var streamInfo = Application.GetResourceStream(
            new Uri("/Silverlight5Samples;component/Sounds/notify.wav", 
                        UriKind.RelativeOrAbsolute));
            SoundEffect soundEffect = SoundEffect.FromStream(streamInfo.Stream);
            // Default playback mode
            soundEffect.Play();

            //SoundEffectInstanceを作成してもよし
            //var sei = soundEffect.CreateInstance();
            //sei.Play();

            //以下のコードでは音が鳴らない
            //using (var sei = soundEffect.CreateInstance())
            //{
            //    sei.Play();
            //}
        }
    }
}
