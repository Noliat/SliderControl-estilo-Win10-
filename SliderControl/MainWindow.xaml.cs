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

namespace SliderControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseWheel += Slider_MouseWheel;
        }

        private void Slider_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            // Verifica se o sender não é null
            if (e.Source is Slider slider)
            {
                // Manipula a rolagem do mouse apenas para o Slider dentro do UserControl
                if (e.Delta > 0)
                {
                    slider.Value += 1;
                }
                else
                {
                    slider.Value -= 1;
                }

                // Impede a propagação do evento para evitar rolagem da janela
                e.Handled = true;
            }
        }
    }
}
