using ShapeCalculator.Model;
using System.Security.Cryptography.X509Certificates;

namespace ShapeCalculator.ViewModel;

public partial class TriangleView : ContentPage
{
	public TriangleModel activeTriangle { get; set; }
	public TriangleView()
	{

        InitializeComponent();
		this.BindingContext = activeTriangle = new TriangleModel();
	}

	public void OnClickBtnCalculate(object sender, EventArgs e)
	{
        activeTriangle.Base = double.Parse(txtBase.Text);
        activeTriangle.Height = double.Parse(txtHeight.Text);
		activeTriangle.CalculateArea();
    }

}