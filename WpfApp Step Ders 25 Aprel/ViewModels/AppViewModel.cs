using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_Step_Ders_25_Aprel.Command;
using WpfApp_Step_Ders_25_Aprel.Models;
using WpfApp_Step_Ders_25_Aprel.Repo;
using WpfApp_Step_Ders_25_Aprel.Views;

namespace WpfApp_Step_Ders_25_Aprel.ViewModels
{
    public class AppViewModel : INotifyPropertyChanged
    {

        public FakeRepo PrinterRepository{ get; set; }

        public ObservableCollection<Printer> Printers { get; set; }



        private Printer _printer;
        public RelayCommand ShowCommand { get; set; }       
        public RelayCommand EditCommand { get; set; }

        public EditViewModel EditViewModel { get; set; }

        public Printer Printer
        {
            get { return _printer; }
            set { _printer = value; OnPropertyChanted(); }
        }


        public AppViewModel()
        {
            PrinterRepository = new FakeRepo();

            Printers = new ObservableCollection<Printer>(PrinterRepository.GetAll());


            Printer = new Printer { Model = "Xerox", Vendor = "Hello", Color = "Black" };

            ShowCommand = new RelayCommand(e =>
            {
                MessageBox.Show($"{Printer.Model} - {Printer.Vendor} - {Printer.Color}");
            }, c =>
            {
                return Printer.Color.Length < 10;
            }
            );            

            EditCommand = new RelayCommand
                (
                    e =>
                    {
                        EditView editView = new EditView();
                        EditViewModel = new EditViewModel
                        {
                            EditPrinter = Printer
                        };
                        editView.DataContext = EditViewModel;
                        editView.ShowDialog();
                    }
                );

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanted([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        
    }
}
