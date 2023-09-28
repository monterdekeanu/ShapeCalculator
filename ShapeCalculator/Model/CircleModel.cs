using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    public class CircleModel : ShapeModel
    {
        private double _radius;
        private double _volumeSphere;


        public double Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                RaisePropertyChanged(nameof(Radius));
            }
        }
        public double VolumeSphere
        {
            get => _volumeSphere;
            set
            {
                _volumeSphere = value;
                RaisePropertyChanged(nameof(VolumeSphere));
            }
        }
        public CircleModel() {
        }
        public void OnClickCalculate()
        {
            //input side entry
            CalculateArea();
            CalculatePerimeter();
            CalculateVolume();
        }
        public void CalculateArea()
        {
            Area = Math.Round(Math.PI * Math.Pow(Radius, 2),4);
        }

        public void CalculatePerimeter()
        {
            Perimeter = Math.Round(2 * Math.PI * Radius, 4);
        }

        public void CalculateVolume()
        {
            VolumeSphere = Math.Round((4 / 3) * Math.PI * Math.Pow(Radius, 3),4);
        }

    }
}
