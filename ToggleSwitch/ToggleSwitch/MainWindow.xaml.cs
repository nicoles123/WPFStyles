using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ToggleSwitch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            anim();
        }

        public async void anim()
        {
            CreateAnEllipse(240, 240, 0.4);
            await Task.Delay(300);
            CreateAnEllipse(240, 240, 0.4);
            await Task.Delay(300);
            CreateAnEllipse(240, 240, 0.4);
        }


        public void CreateAnEllipse(double x, double y, double z)
        {
            // Create an Ellipse    
            Ellipse blueRectangle = new Ellipse();
            
            blueRectangle.Height = x;
            blueRectangle.Width = y;
            // Create a blue and a black Brush    
            SolidColorBrush blueBrush = new SolidColorBrush();
            blueBrush.Color = Color.FromRgb(111,80,220);
            blueBrush.Opacity = z;
            SolidColorBrush blackBrush = new SolidColorBrush();
            blackBrush.Color = Colors.Transparent;
            // Set Ellipse's width and color    
            blueRectangle.StrokeThickness = 0;
            blueRectangle.Stroke = blackBrush;
            // Fill rectangle with blue color    
            blueRectangle.Fill = blueBrush;
            // Add Ellipse to the Grid.    
            LayoutRoot.Children.Add(blueRectangle);

            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 220;
            myDoubleAnimation.To = 330;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(1.5));
            myDoubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            DoubleAnimation myDoubleAnimation2 = new DoubleAnimation();
            myDoubleAnimation2.From = 1;
            myDoubleAnimation2.To = 0;
            myDoubleAnimation2.Duration = new Duration(TimeSpan.FromSeconds(1.5));
            myDoubleAnimation2.RepeatBehavior = RepeatBehavior.Forever;
            blueRectangle.BeginAnimation(Ellipse.WidthProperty, myDoubleAnimation);
            blueRectangle.BeginAnimation(Ellipse.HeightProperty, myDoubleAnimation);
            blueRectangle.BeginAnimation(Ellipse.OpacityProperty, myDoubleAnimation2);
        }
    }
}
