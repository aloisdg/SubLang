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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SubLang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Model.DetectLanguage.DetectLanguageModel.Result res = Model.DetectLanguage.ServiceDetecLanguageModel.DetectSimple("bonjour le monde");

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model.DetectLanguage.DetectLanguageModel.Result res = Model.DetectLanguage.ServiceDetecLanguageModel.DetectSimple("bonjour le monde");
        }
    }
}
