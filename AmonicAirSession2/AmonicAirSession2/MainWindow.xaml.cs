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
using AmonicAirSession2.DataBase;
using System.Windows.Shapes;

namespace AmonicAirSession2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.FontFamily = new FontFamily("Tw Cen MT");
            List<FinalData> finals = new List<FinalData>();
            foreach (var s in new DataBase.DataBase().Schedules)
            {
                finals.Add(new FinalData(s));
            }
            MainGrid.ItemsSource = finals;
        }
    }
}
