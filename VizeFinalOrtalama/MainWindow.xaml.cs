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

namespace VizeFinalOrtalama
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float vize = float.Parse(text1.Text);
                float final = float.Parse(text2.Text);

                if (vize <= 100 && final <= 100 && vize >= 0 && final >= 0)
                {
                    float islem = (float)Math.Round((vize * 0.40 + final * 0.60),2);
                    sonuc.Content = islem;

                }
                else
                {
                    throw new Exception();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Vize ve final notunuzu 0-100 arasinda giriniz.", "Uyari", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}