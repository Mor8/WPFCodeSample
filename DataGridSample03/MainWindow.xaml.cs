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
using System.Collections.ObjectModel;

namespace DataGridSample03
{
    // http://blog.okazuki.jp/entry/20130224/1361693816

    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new ObservableCollection<Person>(
    Enumerable.Range(1, 100).Select(i => new Person
    {
        Name = "田中　太郎" + i,
        Gender = i % 2 == 0 ? Gender.Men : Gender.Women,
        AuthMember = i % 5 == 0
    }));
            DataContext = data;
        }
    }
}
