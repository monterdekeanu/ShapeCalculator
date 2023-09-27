using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    public class TriangleModel : ShapeModel, INotifyPropertyChanged
    {
        private double _base;
        private double _height;
        private double _area;
        private double _volume;
        private double _perimeter;

        public double Base
        {
            get => _base;
            set
            {
                _base = value;
                RaisePropertyChanged(nameof(Base));
            }
        }
        public double Height {             
            get => _height;
                   set
            {
                _height = value;
                RaisePropertyChanged(nameof(Height));
            }
        }

        public double Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                RaisePropertyChanged(nameof(Volume));
            }
        }
        private void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public void CalculateArea()
        {
            Area = Base * Height / 2;
        }

        public TriangleModel() {        }
    }
}
