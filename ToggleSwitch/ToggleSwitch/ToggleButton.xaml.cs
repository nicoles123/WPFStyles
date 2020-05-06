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

namespace ToggleSwitch
{
    /// <summary>
    /// Interaction logic for ToggleButton.xaml
    /// </summary>
    public partial class ToggleButton : UserControl
    {
        Thickness LeftSide = new Thickness(-35, 0, 0, 0);
        Thickness RightSide = new Thickness(0, 0, -35, 0);
        private bool Toggled = false;

        public ToggleButton()
        {
            InitializeComponent();
            Toggled = false;
            Dot.Margin = LeftSide;
            Forward.Opacity = 1;
            Reverse.Opacity = 0.6;
        }

        public bool Toggled1 { get => Toggled; set => Toggled = value; }

        private void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                Toggled = true;
                Dot.Margin = RightSide;
                Forward.Opacity = 0.6;
                Reverse.Opacity = 1;
            }
            else
            {
                Toggled = false;
                Dot.Margin = LeftSide;
                Forward.Opacity = 1;
                Reverse.Opacity = 0.6;
            }
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                Toggled = true;
                Dot.Margin = RightSide;
                Forward.Opacity = 0.6;
                Reverse.Opacity = 1;
            }
            else
            {
                Toggled = false;
                Dot.Margin = LeftSide;
                Forward.Opacity = 1;
                Reverse.Opacity = 0.6;
            }
        }
    }
}
