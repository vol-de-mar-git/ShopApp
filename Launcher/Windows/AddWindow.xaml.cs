using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Launcher.Annotations;
using Launcher.Models;
using TestDb2;

namespace Launcher.Windows
{
    public partial class AddWindow : Window, INotifyPropertyChanged
    {
        public string Name, DesignerName, Category, Brand, Country;
        public int Count;
        public double Price;

        private MainWindowModel _model;

        public List<string> _designerNames, _categories, _brands, _countries;
        
        public List<string> DesignerNames
        {
            get => _designerNames;
            set
            {
                _designerNames = value;
                OnPropertyChanged("DesignerNames");
            }
        }

        public List<string> Categories
        {
            get => _categories;
            set
            {
                _categories = value;
                OnPropertyChanged("Categories");
            }
        }

        public List<string> Brands
        {
            get => _brands;
            set
            {
                _brands = value;
                OnPropertyChanged("Brands");
            }
        }

        public List<string> Countries
        {
            get => _countries;
            set
            {
                _countries = value;
                OnPropertyChanged("Countries");
            }
        }

        public AddWindow(MainWindowModel model)
        {
            _model = model;

            _designerNames = new List<string>();
            _categories = new List<string>();
            _brands = new List<string>();
            _countries = new List<string>();

            GetData();
            
            DesignersBox = new ComboBox();
            CategoriesBox = new ComboBox();
            BrandsBox = new ComboBox();
            CountriesBox = new ComboBox();
            NameBox = new TextBox();
            CountBox = new TextBox();
            PriceBox = new TextBox();

            InitializeComponent();
            DataContext = this;
        }

        private void GetData()
        {
            _designerNames.AddRange(_model._client.GetNames(new NamesRequest {Name = "Designer"}).Names.ToList());
            _categories.AddRange(_model._client.GetNames(new NamesRequest {Name = "Category"}).Names.ToList());
            _brands.AddRange(_model._client.GetNames(new NamesRequest {Name = "Brand"}).Names.ToList());
            _countries.AddRange(_model._client.GetNames(new NamesRequest {Name = "Country"}).Names.ToList());
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Name = NameBox.Text;
            Count = Int32.Parse(CountBox.Text);
            Price = Double.Parse(PriceBox.Text);
            DesignerName = DesignersBox.Text;
            Category = CategoriesBox.Text;
            Brand = BrandsBox.Text;
            Country = CountriesBox.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(DesignerName) || string.IsNullOrEmpty(Category) ||
                string.IsNullOrEmpty(Brand) || string.IsNullOrEmpty(Country))
            {
                MessageBox.Show("Validation Failed");
            }
            else
            {
                _model._client.AddProductAsync(new ProductModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = NameBox.Text,
                    Count = Int32.Parse(CountBox.Text),
                    Price = Double.Parse(PriceBox.Text),
                    Designer = new DesignerModel {Name = DesignersBox.Text},
                    Brand = new BrandModel {Name = BrandsBox.Text},
                    Category = new CategoryModel {Name = CategoriesBox.Text},
                    Country = new CountryModel {Name = CountriesBox.Text}
                });
            }
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}