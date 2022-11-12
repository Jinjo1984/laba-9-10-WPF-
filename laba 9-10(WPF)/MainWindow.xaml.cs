using laba_9_10;
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
using контрольная_2;
using Microsoft.VisualBasic;

namespace laba_9_10_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Massiv proced = new Massiv();
        Utilites utilites = new Utilites();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1Zad_Click(object sender, RoutedEventArgs e)
        {
           
            
            int[] mass = utilites.completeMass(Convert.ToInt32(Interaction.InputBox("Введите длину массива")));
            ListBox1.Items.Add("Массив:");
            ListBox1.Items.Add( utilites.CharackterInTextBox(utilites.ConvertToStr(mass)));
            ListBox1.Items.Add($"Произведение всех чисел в массиве: {proced.multiply(mass)}");
            ListBox1.Items.Add($"Произведение четных чисел в массиве: {proced.multiplyChet(mass)}");
        }

        private void button2Zad_Click(object sender, RoutedEventArgs e)
        {
            int[] mass = utilites.completeMass(Convert.ToInt32(Interaction.InputBox("Введите длину массива")));
            ListBox2.Items.Add("Массив: "+ utilites.CharackterInTextBox(utilites.ConvertToStr(mass)));
            ListBox2.Items.Add(proced.IndexOfMaxElement(mass));
            ListBox2.Items.Add(proced.IndexOfMaxinMinElement(mass));
            ListBox2.Items.Add(proced.IndexOfMinAbsElement(mass));


        }
    }
}
