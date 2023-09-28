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
		activeUnitRow_0.SelectedIndex = 0;
		activeUnitRow_1.SelectedIndex = 0;
		activeUnitRow_2.SelectedIndex = 0;
		
	}
	

	public void OnClickBtnCalculate(object sender, EventArgs e)
	{
        
        int computationCalc = Int32.Parse(((Button)sender).AutomationId);
		try
		{
            if (computationCalc == 0)
            {
                activeTriangle.Base = double.Parse(txtBase.Text);
                activeTriangle.Height = double.Parse(txtHeight.Text);
                activeTriangle.CalculateArea();
            }
            else if (computationCalc == 1)
            {
                activeTriangle.Side1 = double.Parse(txtSide1.Text);
                activeTriangle.Side2 = double.Parse(txtSide2.Text);
                activeTriangle.Side3 = double.Parse(txtSide3.Text);
                activeTriangle.CalculatePerimeter();
            }
            else if (computationCalc == 2)
            {
                activeTriangle.Radius = double.Parse(txtRadius.Text);
                activeTriangle.Height = double.Parse(txtHeight2.Text);
                activeTriangle.CalculateVolume();
            }
        }catch(Exception err)
        {
            Console.WriteLine(err);
            DisplayAlert("Error", "Invalid Input", "Ok");
            if (computationCalc == 0)
            {
                activeTriangle.Base = 0;
                activeTriangle.Height = 0;
                activeTriangle.Area = 0;
            }
            else if (computationCalc == 1)
            {
                activeTriangle.Side1 = 0;
                activeTriangle.Side2 = 0;
                activeTriangle.Side3 = 0;
                activeTriangle.Perimeter = 0;
            }
            else if (computationCalc == 2)
            {
                activeTriangle.Radius = 0;
                activeTriangle.Height = 0;
                activeTriangle.Volume = 0;
            }
        }
    }

}