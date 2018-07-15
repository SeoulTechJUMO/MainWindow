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
using System.Windows.Shapes;

namespace 메인창
{
    /// <summary>
    /// Mixser.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Mixser : Window
    {
        public Mixser()
        {
            InitializeComponent();
        }

        private void Create_Mixser(object sender, RoutedEventArgs e)
        {
            Grid grid = new Grid();
            grid.Width = 146;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;

            TextBlock txt1 = new TextBlock();
            Double db3 = new double();
            db3 = 150000;
            txt1.Text = db3.ToString();
            

            grid.Children.Add(txt1);

            Mixser_StackPanel.Children.Add(grid);
        }
    }
}
