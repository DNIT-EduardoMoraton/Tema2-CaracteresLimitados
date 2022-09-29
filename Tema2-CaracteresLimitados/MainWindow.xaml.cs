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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainTextTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int numOfChars;

            numOfChars = mainTextTextBox.Text.Length;
            indicatorTextBlock.Text = numOfChars.ToString() + " / 140";

            if (numOfChars >= 140)
                mainTextTextBox.IsReadOnly = true;
            else
                mainTextTextBox.IsReadOnly = false;

        }
    }
}
