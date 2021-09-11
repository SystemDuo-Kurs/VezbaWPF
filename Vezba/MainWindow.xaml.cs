using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Vezba
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ZaSabiranje nesto = new();

		ObservableCollection<ZaSabiranje> lista = new();

		public MainWindow()
		{
			InitializeComponent();
			DataContext = nesto;
			tabela.ItemsSource = lista;
			
		}


		
		private void Klik(object sender, RoutedEventArgs e)
		{
			//MessageBox.Show("Zbir je: " + (nesto.Broj1 + nesto.Broj2));
			nesto.Rezultat = nesto.Broj1 + nesto.Broj2;
			lista.Add(nesto);
			nesto = new();
			DataContext = nesto;
		}
	}

	public class ZaSabiranje
	{
		public int Broj1 { get; set; }
		public int Broj2 { get; set;}
		public int Rezultat { get; set; }
	}
}
