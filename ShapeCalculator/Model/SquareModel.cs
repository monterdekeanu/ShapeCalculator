using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    public class SquareModel : ShapeModel
    {
        private double _side;
        private double _volume;

        public double Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                RaisePropertyChanged(nameof(Volume));
            }
        }

        public double Side
        {
            get => _side;
            set
            {
                _side = value;
                RaisePropertyChanged(nameof(Side));
            }
        }

        public SquareModel() { }

        public void OnClickCalculate( )
        {
            ComputeArea();
            ComputePerimeter();
            ComputeVolume();
        }
        private void ComputeArea()
        {
            Area = Math.Round(Side * Side,4);
        }

        private void ComputePerimeter()
        {
            Perimeter = Math.Round(4 * Side,4);
        }

        private void ComputeVolume()
        {
            Volume = Math.Round(Math.Pow(Side, 3),4);
        }
    }
}
