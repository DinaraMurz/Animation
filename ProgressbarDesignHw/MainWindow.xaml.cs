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

            DoubleAnimation rectangleAnimation = new DoubleAnimation();
            rectangleAnimation.From = greenRectangle.ActualWidth;
            rectangleAnimation.To = 400;
            rectangleAnimation.Duration = TimeSpan.FromSeconds(5);
            rectangleAnimation.Completed += ButtonAnimation_Completed;
            greenRectangle.BeginAnimation(Button.WidthProperty, rectangleAnimation);
        }

        private void ButtonAnimation_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Анимация завершена");
        }
    }
}
