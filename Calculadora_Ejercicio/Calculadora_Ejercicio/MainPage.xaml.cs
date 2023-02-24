using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Calculadora_Ejercicio.ViewModels;

namespace Calculadora_Ejercicio.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public CalculatorViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new CalculatorViewModel();
            BindingContext = ViewModel;
        }
    }
}
