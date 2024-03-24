using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lab3.Lib;

namespace Lab4.WPF
{
    public class CalculateArea : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private double _r, _alfa, _area;

        public double R
        {
            get => _r;
            set
            {
                _r = value;
                OnPropertyChanged();
                UpdateArea();
            }
        }
        public double Alfa
        {
            get => _alfa;
            set
            {
                _alfa = value;
                OnPropertyChanged();
                UpdateArea();
            }
        }

        public double Area
        {
            get => _area;
            set
            {
                _area = value;
                OnPropertyChanged(nameof(Area));
            }
        }

        private void UpdateArea()
        {
            Area = Circular_Sector.Calc(R, Alfa);
        }
    }
}
