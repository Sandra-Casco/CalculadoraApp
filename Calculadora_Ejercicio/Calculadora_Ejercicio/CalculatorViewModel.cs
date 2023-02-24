using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

using Calculadora_Ejercicio.Models;

namespace Calculadora_Ejercicio.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private Expression _expression = new Expression();
        private double _result;

        public Expression Expression
        {
            get { return _expression; }
            set
            {
                if (_expression != value)
                {
                    _expression = value;
                    OnPropertyChanged("Expression");
                }
            }
        }

        public double Result
        {
            get { return _result; }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    OnPropertyChanged("Result");
                }
            }
        }

        public ICommand SumCommand { get; private set; }

        public ICommand SubtractCommand { get; private set; }
        public ICommand MultiplyCommand { get; set; }
        public ICommand DivideCommand { get; set; }

        public CalculatorViewModel()
        {
            Expression = new Expression();
            SumCommand = new Command(() => Expression.Num1 = Expression.Sum());
            SubtractCommand = new Command(() => Expression.Num1 = Expression.Subtract());
            MultiplyCommand = new Command(() => Expression.Num1 = Expression.Multiply());
            DivideCommand = new Command(() => Expression.Num1 = Expression.Divide());
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
