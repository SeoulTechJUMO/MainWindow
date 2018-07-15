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
        int Mixser_number = 5;
        ScaleTransform scale = new ScaleTransform(1.5, 1.5);

        public Mixser()
        {
            InitializeComponent();
        }

        private void Create_Mixser(object sender, RoutedEventArgs e)
        {
            //그리드 생성
            Grid grid = new Grid();
            grid.Width = 146;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            grid.VerticalAlignment = VerticalAlignment.Center;

            //믹서에 포함된 콘텐츠 만들기
            //채널이름
            TextBlock text = new TextBlock();
            text.Width = 40;
            text.Height = 30;
            text.Margin = new Thickness(2, 0, 0, 391);
            text.HorizontalAlignment = HorizontalAlignment.Left;
            text.Text = "채널" + Mixser_number.ToString();
            text.Name = "text" + Mixser_number.ToString();
            Mixser_number += 1;

            //왼쪽 믹서
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Height = 205;
            rectangle1.Width = 29;
            rectangle1.Margin = new Thickness(34, 30, 0, 0);
            rectangle1.Fill = System.Windows.Media.Brushes.Gray;
            rectangle1.HorizontalAlignment = HorizontalAlignment.Left;
            rectangle1.VerticalAlignment = VerticalAlignment.Top;
            
            //오른쪽 믹서 생성
            Rectangle rectangle2 = new Rectangle();
            rectangle2.Height = 205;
            rectangle2.Width = 29;
            rectangle2.Margin = new Thickness(90, 30, 0, 0);
            rectangle2.Fill = System.Windows.Media.Brushes.Gray;
            rectangle2.HorizontalAlignment = HorizontalAlignment.Left;
            rectangle2.VerticalAlignment = VerticalAlignment.Top;
            
            //Muto 생성
            CheckBox checkBox_Muto = new CheckBox();
            checkBox_Muto.Height = 15;
            checkBox_Muto.Width = 50;
            checkBox_Muto.Margin = new Thickness(0, 246, 57, 0);
            checkBox_Muto.HorizontalAlignment = HorizontalAlignment.Right;
            checkBox_Muto.VerticalAlignment = VerticalAlignment.Top;
            checkBox_Muto.Content = "Muto";
            checkBox_Muto.RenderTransform = scale;

            //Solo 생성
            CheckBox checkBox_Solo = new CheckBox();
            checkBox_Solo.Height = 15;
            checkBox_Solo.Width = 50;
            checkBox_Solo.Margin = new Thickness(40, 275, 0, 0);
            checkBox_Solo.HorizontalAlignment = HorizontalAlignment.Left;
            checkBox_Solo.VerticalAlignment = VerticalAlignment.Top;
            checkBox_Solo.Content = "Solo";
            checkBox_Solo.RenderTransform = scale;

            //음량 생성
            Button sound = new Button();
            sound.Width = 80;
            sound.Height = 27;
            sound.FontSize = 14;
            sound.Margin = new Thickness(34, 310, 32, 84);
            sound.Content = "음량";

            //팬 생성
            Button pan = new Button();
            pan.Width = 80;
            pan.Height = 27;
            pan.FontSize = 14;
            pan.Margin = new Thickness(34, 346, 32, 48);
            pan.Content = "팬";

            //효과 생성
            Button effect = new Button();
            effect.Width = 80;
            effect.Height = 27;
            effect.FontSize = 14;
            effect.Margin = new Thickness(34, 382, 32, 12);
            effect.Content = "효과";

            //그리드에 콘텐츠 삽입하기
            grid.Children.Add(text);
            grid.Children.Add(rectangle1);
            grid.Children.Add(rectangle2);
            grid.Children.Add(checkBox_Muto);
            grid.Children.Add(checkBox_Solo);
            grid.Children.Add(sound);
            grid.Children.Add(pan);
            grid.Children.Add(effect);

            //StackPenel에 만든 그리드 추가
            Mixser_StackPanel.Children.Add(grid);
        }
    }
}
