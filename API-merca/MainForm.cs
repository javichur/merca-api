using API_merca.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace API_merca
{
    public partial class MainForm : Form
    {
        private static string _URL_API_BASE = ""; // url base de la API
        private static string _URL_API_PRODUCTS = _URL_API_BASE + "products/";
        private static string _URL_API_CATEGORIES = _URL_API_BASE + "categories/";

        private static int _DELAY = 1000; // milisegundos de pausa entre llamadas de API

        public static string _PATH = "./";
        public static string _CATEGORIES_FOLDER = _PATH + "categories/";
        public static string _PRODUCTS_FOLDER = _PATH + "products/";

        // fichero local de categorias. Se usa para leer las categorías y prouctos
        public static string _CATEGORIES_JSON = "categories.json";

        private int contadorProductos = 0;
        private int contadorCategorias = 0;

        private Dictionary<string, ProductClass> dictionaryProducts = null;
        private Dictionary<int, CategoryClass> dictionaryCateogies = null;

        public MainForm()
        {
            InitializeComponent();

            // load URL API Base + Delay from ".config" file
            txtUrlApiBase.Text = Properties.Settings.Default.URL_API_BASE;
            txtDelay.Text = Properties.Settings.Default.DELAY.ToString();

            if (!Directory.Exists(_CATEGORIES_FOLDER)) {
                Directory.CreateDirectory(_CATEGORIES_FOLDER);
            }
            if (!Directory.Exists(_PRODUCTS_FOLDER))
            {
                Directory.CreateDirectory(_PRODUCTS_FOLDER);
            }

            lblContadorCategorias.Text = "...";
            lblContadorProductos.Text = "...";
            lblContadorProductosSinRepes.Text = "...";

            dictionaryProducts = new Dictionary<string, ProductClass>();
            dictionaryCateogies = new Dictionary<int, CategoryClass>();
        }

        private void DownloadCategory(int id)
        {
            WebClient client = new WebClient();
            string url = _URL_API_CATEGORIES + id.ToString();
            client.DownloadFile(url, _CATEGORIES_FOLDER + id.ToString());
        }

        private void DownloadProduct(string id)
        {
            var client = new WebClient();
            string url = _URL_API_PRODUCTS + id;

#if DEBUG
            Console.WriteLine("Downloading " + url);
#endif
            client.DownloadFile(url, _PRODUCTS_FOLDER + id.ToString());
        }

        private void btnLeerCategorias_Click(object sender, EventArgs e)
        {
            this.contadorProductos = 0;
            this.contadorCategorias = 0;

            this.dictionaryProducts.Clear();
            this.dictionaryCateogies.Clear();

            string strJson = File.ReadAllText(_PATH + _CATEGORIES_JSON);

            CategoriesRootClass lista = JsonConvert.DeserializeObject<CategoriesRootClass>(strJson);

            var tab = "";
            listBoxCategorias.Items.Clear();
            MostrarListadoCategoriasDesdeArray(lista.results, tab);

            lblContadorProductos.Text = this.contadorProductos.ToString();
            lblContadorCategorias.Text = this.contadorCategorias.ToString();            
            lblContadorProductosSinRepes.Text = this.dictionaryProducts.Count.ToString();
        }

        private void MostrarListadoCategoriasDesdeArray(List<CategoryClass> categorias, string tab)
        {
            if (categorias == null)
                return;

            foreach (var unaCat in categorias)
            {
                var strProds = "";
                if (unaCat.products != null)
                {
                    strProds = " (" + unaCat.products.Count.ToString() + " prods)";                    
                }

                var item = new MyListBoxItem()
                {
                    Tag = unaCat,
                    Text = tab + unaCat.id.ToString() + " - " + unaCat.name + strProds
                };
                
                listBoxCategorias.Items.Add(item);

                this.dictionaryCateogies.Add(unaCat.id, unaCat);
                this.contadorCategorias++;

                if (unaCat.products != null)
                {                    
                    foreach (var unProd in unaCat.products)
                    {
                        if (!dictionaryProducts.ContainsKey(unProd.id))
                        {
                            this.dictionaryProducts.Add(unProd.id, unProd);                       
                        }

                        item = new MyListBoxItem() { Tag = unProd, Text = tab + "\t" + unProd.id + " - " + unProd.display_name };
                        listBoxCategorias.Items.Add(item);

                        if (!File.Exists(_PRODUCTS_FOLDER + unProd.id.ToString()))
                        {
                            DownloadProduct(unProd.id);
                            System.Threading.Thread.Sleep(_DELAY);
                        }
                        
                        this.contadorProductos++;
                    }
                }

                if (unaCat.categories != null)
                {
                    MostrarListadoCategoriasDesdeArray(unaCat.categories, tab + "\t"); // recursive
                }
                else {
                    var detalleSubcat = ParsearUnaCategoriaDescargarAntesSiNoExisteFichero(unaCat.id);
                    MostrarListadoCategoriasDesdeArray(detalleSubcat.categories, tab + "\t"); // recursive
                }
            }            
        }

        /// <summary>
        /// Intenta abrir fichero para parsear categoria. Si no puede abrir fichero, intenta descargarlo y después parsarlo.
        /// </summary>
        /// <param name="id">Identificador de la categoría.</param>
        /// <returns></returns>
        private CategoryClass ParsearUnaCategoriaDescargarAntesSiNoExisteFichero(int id)
        {
            string strJson = "";
            var path = _PATH + _CATEGORIES_FOLDER + id.ToString();
            if (!File.Exists(path)) {
                Console.WriteLine("Error al abrir fichero de categoría ID=" + id.ToString() + ".");
                
                try
                {
                    DownloadCategory(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al descargar fichero de categoría ID=" + id.ToString() + ". " + ex.Message);
                }
            }

            try
            {
                strJson = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir fichero de categoría ID=" + id.ToString() + ". " + ex.Message);
            }

            CategoryClass una = JsonConvert.DeserializeObject<CategoryClass>(strJson);
            return una;
        }

        private void btnProductsToXml_Click(object sender, EventArgs e)
        {
            serializarArray(this.dictionaryProducts.Values.ToArray(), "products.xml");

            MessageBox.Show("Exported " + this.dictionaryProducts.Values.Count.ToString() + " items in products.xml");
        }

        private void btnCategoriesToXml_Click(object sender, EventArgs e)
        {
            serializarArray(this.dictionaryCateogies.Values.ToArray(), "categories.xml");

            MessageBox.Show("Exported " + this.dictionaryCateogies.Values.Count.ToString() + " items in categories.xml");
        }

        private void serializarArray(IEnumerable<Object> listado, string nombreFichero)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(listado.GetType());

            var fileStream = new FileStream(nombreFichero, FileMode.Create);

            x.Serialize(fileStream, listado);
            fileStream.Flush();
            fileStream.Close();
        }

        private void btnGuardarUrlApiBase_Click(object sender, EventArgs e)
        {
            var url = txtUrlApiBase.Text.Trim();
            var delay = txtDelay.Text.Trim();

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                if (!url.EndsWith("/"))
                {
                    url += "/";
                    txtUrlApiBase.Text = url;
                }

                Properties.Settings.Default.URL_API_BASE = url;
                Properties.Settings.Default.Save();
            }
            else {
                MessageBox.Show("Escribe una URL Base de API válida.");
                return;
            }

            int valorDelay;
            if (int.TryParse(delay, out valorDelay) && valorDelay >= 100)
            {
                Properties.Settings.Default.DELAY = valorDelay;
                Properties.Settings.Default.Save();
            }
            else {
                MessageBox.Show("Escribe valor de 'Delay' (milisegundos) válido y mayor que 100.");
                return;
            }

            MessageBox.Show("Saved :D");
        }

        /// <summary>
        /// Muestra imagen en miniatura (si hay) al seleccionar un producto de la lista.
        /// Muestra mensaje con las instrucciones de uso si las hay.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxProduct.Image = null;

            if (listBoxCategorias.SelectedItem != null)
            {
                if (listBoxCategorias.SelectedItem is MyListBoxItem && 
                    ((MyListBoxItem) listBoxCategorias.SelectedItem).Tag is ProductClass) {

                    var p = (ProductClass)((MyListBoxItem)listBoxCategorias.SelectedItem).Tag;
                    if (p.thumbnail != null) pictureBoxProduct.Load(p.thumbnail);
                    if (p.usage_instructions != null)
                    {                        
                        MessageBox.Show(p.usage_instructions);
                    }
                }
            }
        }
    }
}
