using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_Step_Ders_25_Aprel.Command;
using WpfApp_Step_Ders_25_Aprel.Models;

namespace WpfApp_Step_Ders_25_Aprel.ViewModels
{
    public class EditViewModel : INotifyPropertyChanged
    {        
        private Printer _printer;
        public RelayCommand SaveCommand { get; set; }

        public EditViewModel()
        {
            SaveCommand = new RelayCommand(delegate { MessageBox.Show("Save Successfully"); });
        }

        public Printer EditPrinter
        {
            get { return _printer; }
            set { _printer = value; OnPropertyChanted(); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanted([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }



    }
}
