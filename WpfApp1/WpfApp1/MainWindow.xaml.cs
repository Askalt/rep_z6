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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Glosy { get; set; } = 0;
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;
        public int C { get; set; } = 0;
        public int D { get; set; } = 0;
        public double maxH
        {
            get => canvas.Height;
        }
        public double help_czesc { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Wysokosc_okna()
        {
            Canvas.SetTop(wariant_A, maxH - ((A / Glosy) * maxH));
            Canvas.SetTop(wariant_B, maxH - ((B / Glosy) * maxH));
            Canvas.SetTop(wariant_C, maxH - ((C / Glosy) * maxH));
            Canvas.SetTop(wariant_D, maxH - ((D / Glosy) * maxH));
        }
        private void Max_vote()
        {
            if (A>B&&A>C&&A>D)
            {
                max_vote_lab.Content = "A";
                ilosc_max.Content = ilosc_a.Content;
            }
            if (B > C && B > A && B > D)
            {
                max_vote_lab.Content = "B";
                ilosc_max.Content = ilosc_b.Content;
            }
            if (C > B && C > B && C > D)
            {
                max_vote_lab.Content = "C";
                ilosc_max.Content = ilosc_c.Content;
            }
            if (D > B && D > C && D > A)
            {
                max_vote_lab.Content = "D";
                ilosc_max.Content = ilosc_d.Content;
            }
        }

        private void Click_A_Click(object sender, RoutedEventArgs e)
        {
            ++A;
            ++Glosy;
            help_czesc = A / Glosy;
            wariant_A.Height = maxH * help_czesc;
            Wysokosc_okna();
            l_all_vote.Content = Glosy.ToString();
            ilosc_a.Content = A.ToString();
            Max_vote();
        }

        private void Click_B_Click(object sender, RoutedEventArgs e)
        {
            ++B;
            ++Glosy;
            help_czesc = B / Glosy;
            wariant_B.Height = maxH * help_czesc;
            Wysokosc_okna();
            l_all_vote.Content = Glosy.ToString();
            ilosc_b.Content = B.ToString();
            Max_vote();
        }

        private void Click_C_Click(object sender, RoutedEventArgs e)
        {
            ++C;
            ++Glosy;
            help_czesc = C / Glosy;
            wariant_C.Height = maxH * help_czesc;
            Wysokosc_okna();
            l_all_vote.Content = Glosy.ToString();
            ilosc_c.Content = C.ToString();
            Max_vote();
        }

        private void Click_D_Click(object sender, RoutedEventArgs e)
        {
            ++D;
            ++Glosy;
            help_czesc = D / Glosy;
            wariant_D.Height = maxH * help_czesc;
            Wysokosc_okna();
            l_all_vote.Content = Glosy.ToString();
            ilosc_d.Content = D.ToString();
            Max_vote();
        }
    }

}
