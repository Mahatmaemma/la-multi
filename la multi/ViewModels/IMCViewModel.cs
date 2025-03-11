using la_multi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace la_multi.ViewModels
{
    public class IMCViewModel : INotifyPropertyChanged
    {
        private double altura;
        private double peso;
        private string resultado;
        private string category;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Altura
        {
            get => altura;
            set
            {
                if (altura != value)
                {
                    altura = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Peso
        {
            get => peso;
            set
            {
                if (peso != value)
                {
                    peso = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Resultado
        {
            get => resultado;
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Category
        {
            get => category;
            set
            {
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularIMCCommand { get; }

        public IMCViewModel()
        {
            CalcularIMCCommand = new Command(CalcularIMC);
        }

        private void CalcularIMC()
        {
            var imcModel = new IMCModel { Altura = Altura, Peso = Peso };
            var imc = imcModel.CalcularIMC();
            Resultado = imc.ToString("F2");
            Category = imcModel.GetResultadoIMC(imc);
        }

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}