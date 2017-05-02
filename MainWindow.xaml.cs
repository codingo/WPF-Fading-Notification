using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSandbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {
            LabelTicketSubmittedCopy.Opacity = 1;

            var storyboard = new Storyboard();
            var duration = new TimeSpan(0, 0, 2);

            DoubleAnimation animation = new DoubleAnimation();

            animation.From = 1.0;
            animation.To = 0.0;
            animation.Duration = new Duration(duration);

            Storyboard.SetTargetName(animation, LabelTicketSubmittedCopy.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Control.OpacityProperty));

            storyboard.Children.Add(animation);

            // Begin the storyboard
            storyboard.Begin(this);
        }
    }
}
