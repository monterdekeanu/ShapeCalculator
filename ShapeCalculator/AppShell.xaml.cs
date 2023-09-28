using ShapeCalculator.ViewModel;

namespace ShapeCalculator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TriangleView), typeof(TriangleView));
            Routing.RegisterRoute(nameof(SquareView), typeof(SquareView));
            Routing.RegisterRoute(nameof(CircleViewModel), typeof(CircleViewModel));
            Routing.RegisterRoute(nameof(RectangleViewModel), typeof(RectangleViewModel));
            
        }
    }
}