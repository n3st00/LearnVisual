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

namespace LearnVisual.UserControls
{
    /// <summary>
    /// Interaction logic for LogoWindow.xaml
    /// </summary>
    public partial class LogoWindow : UserControl
    {
        public delegate Task LogoButtonClickedEventHandler(object sender, EventArgs e);
        public event LogoButtonClickedEventHandler LogoButtonClicked;

        public LogoWindow()
        {
            InitializeComponent();
        }


       

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the storyboard from resources
            var storyboard = Resources["DisappearAnimation"] as Storyboard;
            // Begin the animation
            storyboard?.Begin();
            // Wait for the animation to complete
            await Task.Delay(1000); // Adjust the delay based on the animation duration

            LogoButtonClicked.Invoke(this, EventArgs.Empty);

        }
    }
}
