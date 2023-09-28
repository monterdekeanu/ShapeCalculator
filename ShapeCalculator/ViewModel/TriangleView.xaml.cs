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
	
    public void OnClickUnitChange(object sender, EventArgs e)
    {
        int unitLblId = Int32.Parse(((Picker)sender).AutomationId);
        if (unitLblId == 0)
        {
            triangleUnit_0.Text = ((Picker)sender).SelectedItem.ToString() + " ^2";
        }else if(unitLblId == 1)
        {
            triangleUnit_1.Text = ((Picker)sender).SelectedItem.ToString();
        }else if(unitLblId == 2)
        {
            triangleUnit_2.Text = ((Picker)sender).SelectedItem.ToString() + " ^3";
        }
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
            DisplayAlert("Invalid Input", "Numeric Input Only", "Ok");
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
    public void OnClickBtnClear(object sender, EventArgs e)
    {
        int clearId = Int32.Parse(((Button)sender).AutomationId);

        if(clearId == 0)
        {
            txtBase.Text = "0";
            txtHeight.Text = "0";
            activeTriangle.Area = 0;
        }else if(clearId == 1)
        {
            txtSide1.Text = "0";
            txtSide2.Text = "0";
            txtSide3.Text = "0";
            activeTriangle.Perimeter = 0;
        }else if( clearId == 2)
        {
            txtRadius.Text = "0";
            txtHeight2.Text = "0";
            activeTriangle.Volume = 0;
        }
    }

}