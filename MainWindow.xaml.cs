using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var items = new ObservableCollection<Item>
            {
                new Item { Name = "Задача 1", Date = DateTime.Now.AddDays(-5) },
                new Item { Name = "Задача 2", Date = DateTime.Now.AddDays(-2) },
                new Item { Name = "Важное событие", Date = DateTime.Now.AddDays(3) },
                new Item { Name = "Встреча", Date = DateTime.Now.AddDays(7) },
                new Item { Name = "Отчет", Date = DateTime.Now.AddDays(10) }
            };

            dataGrid.ItemsSource = items;
            progressBar.Value = 75;
        }
        public class Item
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
        }
    }
}