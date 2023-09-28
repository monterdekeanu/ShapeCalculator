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
        private double _volume;
        private double _side1;
        private double _side2;
        private double _side3;
        private double _radius;


        public double Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                RaisePropertyChanged(nameof(Radius));
            }
        }


        public double Side1
        {
            get => _side1;
            set{
                _side1 = value;
                RaisePropertyChanged(nameof(Side1));
            }
        }
        public double Side2
        {
            get => _side2;
            set
            {
                _side2 = value;
                RaisePropertyChanged(nameof(Side2));
            }
        }
        public double Side3
        {
            get => _side3;
            set
            {
                _side3 = value;
                RaisePropertyChanged(nameof(Side3));
            }
        }
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
        public void CalculatePerimeter()
        {
            Perimeter = Side1 + Side2 + Side3;
        }

        public void CalculateArea()
        {
            Area = Base * Height / 2;
        }

        public void CalculateVolume()
        {
            Volume = Math.Round((Math.PI * Math.Pow(Radius, 2) * Height) / 3,4);
        }

        public TriangleModel() {        }
    }
}
