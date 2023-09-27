using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    public class ShapeModel : INotifyPropertyChanged
    {
        private double _area;
        private double _perimeter;

        public double Area{
            get => _area;
            set
            {
                _area = value;
                RaisePropertyChanged(nameof(Area));
            }
        }

        public double Perimeter
        {
            get => _perimeter;
            set
            {
                _perimeter = value;
                RaisePropertyChanged(nameof(Perimeter));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
