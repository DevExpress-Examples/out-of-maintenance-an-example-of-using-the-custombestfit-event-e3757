using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] source = new string[] { "123456789", "1234567890", "12345678901", "123456789012" };
            gridControl1.ItemsSource = source;
            
        }
        private void tableView1_CustomBestFit(object sender, DevExpress.Xpf.Grid.CustomBestFitEventArgs e)
        {
            LinkedList<int> selectedRows = new LinkedList<int>();
            foreach (ListBoxItem item in listBoxEdit1.SelectedItems)
                if (item.IsEnabled)
                    selectedRows.AddLast(Convert.ToInt32(item.Content));
            e.BestFitRows = selectedRows;
        }
    }
}
