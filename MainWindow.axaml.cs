using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Phone2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            b1.Click += OpenForm;
        }
        private void OpenForm(object? sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        private void ClickHandler(object sender, RoutedEventArgs args)
        {
            int[] nomera = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int num = 1000 * nomera[0] + 100 * nomera[1] + 10 * nomera[2] + nomera[3];
            //char[] nomera = ("0123456789").ToCharArray();
            Random random = new Random();
            //var randomNomera = random.Next(0, nomera.Length);
            var randomNomera = random.Next();
            string nom = null;
            for (int i = 0; i < nomera.Length; i++)
            {
                nom += nomera[i].ToString();
            }
            message.Text = $"{randomNomera}";
        }

    }
}