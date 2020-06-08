using System;
using System.Collections.Generic;
using System.IO;
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

namespace MagicSquare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] Symbols;
        public string TrueSymbol { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Random rand = new Random();
            string str = @"✱
★
$
✈
৳
₭
︽
︻
♖
♦
♬
☁
☄
㎏
♝
♤
➡
☸
♓
☹
∭
∩
⋛
⌦
⚫";
            Symbols = str.Split(new char[] { ' ','\n' }, StringSplitOptions.RemoveEmptyEntries);         
            TrueSymbol = Symbols[rand.Next(0, Symbols.Length-1)];
            int n = 99;
            int currentPosition = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Label dynamicLabel = new Label();
                    dynamicLabel.Name = "NewLabel";
                    dynamicLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
                    dynamicLabel.VerticalAlignment = VerticalAlignment.Center;
                    dynamicLabel.Content = $"{n} {Symbols[rand.Next(0,Symbols.Length-1)]}";
                    dynamicLabel.Width = 50;
                    dynamicLabel.Height = 40;
                    dynamicLabel.Foreground = new SolidColorBrush(Colors.White);
                    dynamicLabel.Background = new SolidColorBrush(Colors.Black);

                    gridForSymbols.Children.Add(dynamicLabel);

                    Grid.SetRow(dynamicLabel, i);
                    Grid.SetColumn(dynamicLabel, j);
                   
                    if(currentPosition%9==0)
                        dynamicLabel.Content = $"{n} {TrueSymbol}";

                    currentPosition++;
                    --n;
                }
            }
        }

        private void ButtonBlackSquare_Click(object sender, RoutedEventArgs e)
        {
            UserSymbol userSymbol = new UserSymbol(TrueSymbol);
            this.Close();
            userSymbol.ShowDialog();
        }
    }
}
