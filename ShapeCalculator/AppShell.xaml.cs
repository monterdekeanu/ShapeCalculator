using ShapeCalculator.ViewModel;

namespace ShapeCalculator
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TriangleView), typeof(TriangleView));
        }
    }
}