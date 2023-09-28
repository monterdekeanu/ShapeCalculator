using ShapeCalculator.Model;
namespace ShapeCalculator.ViewModel;

public partial class RectangleViewModel : ContentPage
{

    public RectangleModel activeRectangle { get; set; }
	public RectangleViewModel()
	{
		InitializeComponent();
        this.BindingContext = activeRectangle = new RectangleModel();
		activeUnitRow_0.SelectedIndex = 0;
		activeUnitRow_2.SelectedIndex = 0;
	}

    public void OnClickUnitChange(object sender, EventArgs e)
    {
        int unitLblId = Int32.Parse(((Picker)sender).AutomationId);
        if (unitLblId == 0)
        {
            rectangleUnit_0.Text = ((Picker)sender).SelectedItem.ToString() + " ^2";
            rectangleUnit_1.Text = ((Picker)sender).SelectedItem.ToString();
        }
        else if (unitLblId == 1)
        {
            rectangleUnit_2.Text = ((Picker)sender).SelectedItem.ToString() + " ^3";
        }
    }


    public void OnClickBtnCalculate(object sender, EventArgs e)
    {

        int computationCalc = Int32.Parse(((Button)sender).AutomationId);
        try
        {
            if (computationCalc == 0)
            {
                if(txtLength.Text == null || txtWidth.Text == null || txtLength.Text == "0" || txtWidth.Text == "0")
                {
                    DisplayAlert("Invalid Input", "Double Check Your Input", "Ok");
                    return;
                }
                activeRectangle.Length = double.Parse(txtLength.Text);
                activeRectangle.Width = double.Parse(txtWidth.Text);
                activeRectangle.CalculateArea();
                activeRectangle.CalculatePerimeter();
            }
            else if (computationCalc == 1)
            {
                activeRectangle.Width = double.Parse(txtWidth2.Text);
                activeRectangle.Length = double.Parse(txtLength2.Text);
                activeRectangle.Height = double.Parse(txtHeight.Text);
                activeRectangle.CalculateVolume();
            }
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
            DisplayAlert("Invalid Input", "Numeric Input Only", "Ok");
            if (computationCalc == 0)
            {
                activeRectangle.Length = 0;
                activeRectangle.Height = 0;
            }
            else if (computationCalc == 1)
            {
                activeRectangle.Length = 0;
                activeRectangle.Height = 0;
                activeRectangle.Height = 0;
            }
        }
    }
    public void OnClickBtnClear(object sender, EventArgs e)
    {
        int clearId = Int32.Parse(((Button)sender).AutomationId);

        if (clearId == 0)
        {
            txtLength.Text = "0";
            txtWidth.Text = "0";
            activeRectangle.Area = 0;
            activeRectangle.Perimeter = 0;
        }
        else if (clearId == 1)
        {
            txtLength2.Text = "0";
            txtHeight.Text = "0";
            txtWidth2.Text = "0";
            activeRectangle.Volume = 0;
        }
    }
}