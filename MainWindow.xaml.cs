using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
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
using LearnVisual.UserControls; 


namespace LearnVisual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LogoWindow logoWindowInstance = new LogoWindow();
            LoadUserControl(logoWindowInstance);
            logoWindowInstance.LogoButtonClicked += HandleLogoWindowEvent;

        }

        private async Task HandleLogoWindowEvent(object sender, EventArgs e) 
        {
            Content = null;

        }
        private void LoadUserControl(UserControl userControl)
        {
            Content = userControl;

        }

    }
}