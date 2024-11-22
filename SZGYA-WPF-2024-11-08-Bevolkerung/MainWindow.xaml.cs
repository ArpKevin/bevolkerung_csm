using System.IO;
using System.Text;
using System.Windows;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.

namespace SZGYA_WPF_2024_11_08_Bevolkerung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Allampolgar> lakossag;
        Dictionary<string, Megoldas> megoldasok;
        public MainWindow()
        {
            InitializeComponent();
            lakossag = new();
            var sr = new StreamReader("../../../src/bevölkerung.txt", Encoding.UTF8);
            _ = sr.ReadLine(); // fejléc
            while(!sr.EndOfStream)
            {
                lakossag.Add(new Allampolgar(sr.ReadLine()));
            }
            sr.Close();
            dtgrdMegoldas.ItemsSource = lakossag;
            var mods = Assembly.GetExecutingAssembly().DefinedTypes;
            megoldasok = new();
            foreach (var megoldas in mods.Where(m => m.Name.Contains("Megoldas") && m.Name.Length > "Megoldas".Length))
            {
                string key = $"{megoldas.Name.Replace("Megoldas", "")}.";
                megoldasok.Add(key ,(Megoldas)Assembly.GetExecutingAssembly().CreateInstance(megoldas.FullName, false, args: new object[]{ lakossag}, bindingAttr: BindingFlags.Default, binder: null, culture: null, activationAttributes: new object[] {}));

            }
            var kulcsok = megoldasok.Keys.ToList();
            kulcsok.Sort((a, b) => int.Parse(a.Replace(".", "")).CompareTo(int.Parse(b.Replace(".", ""))));
            kulcsok.ForEach(k => cmbFeladat.Items.Add(k));
        }

        private void cmbFeladat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztottMegoldas = megoldasok[cmbFeladat.SelectedItem as string];
            lblMegoldas.Content = kivalasztottMegoldas.MondatValasz();
            dtgrdMegoldas.ItemsSource = kivalasztottMegoldas.GridValasz();
            lstvwMegoldas.ItemsSource = kivalasztottMegoldas.ListaValasz();
        }
    }
}