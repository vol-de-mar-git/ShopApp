
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Accessibility;
using Launcher.Annotations;
using Launcher.Models;
using Launcher.Windows;
using TestDb2;

namespace Launcher.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand AddCommand => _addCommand ??= new RelayCommand(o => OpenAddPage());

        public ICommand DeleteCommand => _deleteCommand ??= new RelayCommand(o => DeleteItem());

        public ICommand BuyCommand => _buyCommand ??= new RelayCommand(o => BuyItem());

        private MainWindowModel _model;

        private ICommand _addCommand, _deleteCommand, _buyCommand;
        public List<ProductModel> Products
        {
            get { return _model.Products;}
            set
            {
                _model.Products = value;
                OnPropertyChanged("Products");
            }
        }

        public MainWindowViewModel(MainWindowModel model)
        {
            _model = model;

            GetProducts();
        }

        private void GetProducts()
        {
            var resp =  _model._client.GetProducts(new Empty());
            _model.Products = resp.Products.ToList();
        }
        
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void OpenAddPage()
        {
            var window = new AddWindow(_model);
            window.Show();
        }

        public void DeleteItem()
        {
            
        }

        public void BuyItem()
        {
            
        }

    }
}