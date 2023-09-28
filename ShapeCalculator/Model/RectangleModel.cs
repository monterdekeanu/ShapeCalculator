using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    public class RectangleModel : ShapeModel
    {
        private double _length;
        private double _width;
        private double _height;
        private double _volume;
        public double Volume
        {
            get => _volume; set
            {
                _volume = value;
                RaisePropertyChanged(nameof(Volume));
            }
        }
        public double Length
        {
            get => _length; set
            {
                _length = value;
                RaisePropertyChanged(nameof(Length));
            }
        }
        public double Width
        {
            get => _width; set
            {
                _width = value;
                RaisePropertyChanged(nameof(Width));
            }
        }
        public double Height
        {
            get => _height; set
            {
                _height = value;
                RaisePropertyChanged(nameof(Height));
            }
        }
        public RectangleModel()
        {

        }

        public void CalculateArea()
        {
            Area = Length * Width;
        }
        public void CalculatePerimeter()
        {
            Perimeter = 2 * (Length + Width);
        }
        public void CalculateVolume()
        {
            Volume = Length * Width * Height;
        }
    }
}
