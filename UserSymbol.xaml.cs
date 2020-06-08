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

namespace MagicSquare
{
    /// <summary>
    /// Interaction logic for UserSymbol.xaml
    /// </summary>
    public partial class UserSymbol : Window
    {
        public UserSymbol(string symbol)
        {
            InitializeComponent();
            buttonUserSymbol.Content = symbol;
        }
    }
}
