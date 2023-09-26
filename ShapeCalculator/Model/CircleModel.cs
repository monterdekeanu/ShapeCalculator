using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator.Model
{
    internal class CircleModel : ShapeModel
    {
        public decimal Radius { get; set; }
        public decimal VolumeSphere { get; set; }

        public CircleModel() {
            this.Radius = 0;
            this.VolumeSphere = 0;
            this.Area = 0;
            this.Perimeter = 0;
        }



    }
}
