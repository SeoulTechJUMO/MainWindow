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
    /// Patten.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Patten : Window
    {
        ScaleTransform scale = new ScaleTransform(2, 2);

        public Patten()
        {
            InitializeComponent();
        }

        private void PianoLoll_Click(object sender, RoutedEventArgs e)
        {
            PianoRoll winFileOpen = new PianoRoll();
            winFileOpen.Owner = this;
            if (winFileOpen.ShowDialog() == true)
            {

            }
        }

        //패턴 추가
        private void Create_Patten(object sender, RoutedEventArgs e)
        {
            // 그리드 생성
            Grid grid = new Grid();
            grid.Height = 80;

            //체크박스 생성
            CheckBox checkBox = new CheckBox();
            checkBox.Height = 15;
            checkBox.Width = 16;
            checkBox.Margin = new Thickness(28, 26, 0, 0);
            checkBox.HorizontalAlignment = HorizontalAlignment.Left;
            checkBox.VerticalAlignment = VerticalAlignment.Top;
            checkBox.RenderTransform = scale;

            //채널 종류
            ComboBox combo = new ComboBox();
            combo.Width = 75;
            combo.Height = 22;
            combo.Margin = new Thickness(86, 30, 0, 0);
            combo.HorizontalAlignment = HorizontalAlignment.Left;
            combo.VerticalAlignment = VerticalAlignment.Top;
            combo.IsEditable = true;

            //vst 종류 바꾸는 버튼
            Button vst_change = new Button();
            vst_change.Width = 120;
            vst_change.Height = 25;
            vst_change.FontSize = 14;
            vst_change.Margin = new Thickness(190, 28, 0, 0);
            vst_change.HorizontalAlignment = HorizontalAlignment.Left;
            vst_change.VerticalAlignment = VerticalAlignment.Top;
            vst_change.Content = "VST"; //추후 동적으로 수정

            //패턴이 보이는 창
            Button mirror = new Button();
            mirror.Width = 418;
            mirror.Height = 57;
            mirror.FontSize = 14;
            mirror.Margin = new Thickness(344, 11, 0, 0);
            mirror.Background = null;
            mirror.HorizontalAlignment = HorizontalAlignment.Left;
            mirror.VerticalAlignment = VerticalAlignment.Top;

            grid.Children.Add(checkBox);
            grid.Children.Add(combo);
            grid.Children.Add(vst_change);
            grid.Children.Add(mirror);

            Patten_StackPanel.Children.Add(grid);
        }
    }
}
