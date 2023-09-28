using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    internal class CircleModel : ShapeModel
    {
        private double _radius;
        private double _volumeSphere;

        public CircleModel() {
        }
        public void CalculateArea()
        {
            //Area = Math.PI * Math.Pow(Radius, 2);
        }

        public void CalculatePerimeter()
        {
            //Perimeter = 2 * Math.PI * Radius;
        }

        public void CalculateVolume()
        {
            //VolumeSphere = (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }

    }
}
