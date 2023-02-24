using System.ComponentModel;

namespace Calculadora_Ejercicio.Models
{
    public class Expression : INotifyPropertyChanged
    {
        private double _num1;
        private double _num2;

        public double Num1
        {
            get { return _num1; }
            set
            {
                if (_num1 != value)
                {
                    _num1 = value;
                    OnPropertyChanged("Num1");
                }
            }
        }

        public double Num2
        {
            get { return _num2; }
            set
            {
                if (_num2 != value)
                {
                    _num2 = value;
                    OnPropertyChanged("Num2");
                }
            }
        }

        public double Sum()
        {
            return Num1 + Num2;
        }

        public double Subtract()
        {
            return Num1 - Num2;
        }

        public double Multiply()
        {
            return Num1 * Num2;
        }

        public double Divide()
        {
            return Num1 / Num2;
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
