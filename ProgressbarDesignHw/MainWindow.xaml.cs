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

namespace ProgressbarDesignHw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DateTime dateTime = new DateTime();
            double loadTime = 3;

            DoubleAnimation animation = new DoubleAnimation
            {
                From = greenRectangle.Width,
                To = greenRectangle.Width + 400,
                Duration = new Duration(TimeSpan.FromSeconds(loadTime)),
                //RepeatBehavior = RepeatBehavior.Forever,
                //AutoReverse = true
            };

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, greenRectangle.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Rectangle.WidthProperty));
            storyboard.Begin(this);
            dateTime = DateTime.Now;

            if (dateTime >= DateTime.Now.AddSeconds(3))
            {
                MessageBox.Show("dfdg");
            }

        }

        public void Storyboard_Completed(object sender, EventArgs e)
        {
           

            DoubleAnimation animationS = new DoubleAnimation
            {
                From = greenRectangle.Width,
                To = greenRectangle.Width + 20,
                Duration = new Duration(TimeSpan.FromSeconds(5))
                //RepeatBehavior = RepeatBehavior.Forever,
                //AutoReverse = true
            };

            Storyboard storyboardS = new Storyboard();
            storyboardS.Children.Add(animationS);
            Storyboard.SetTargetName(animationS, greenRectangle.Name);
            Storyboard.SetTargetProperty(animationS, new PropertyPath(Rectangle.WidthProperty));
            storyboardS.Begin(this);
        }
    }
}
