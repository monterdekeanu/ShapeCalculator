using ShapeCalculator.Model;

namespace ShapeCalculator.ViewModel;

public partial class CircleViewModel : ContentPage
{
    public CircleModel activeCircle { get; set; }
    public CircleViewModel()
	{
		InitializeComponent();

        this.BindingContext = activeCircle = new CircleModel();
        activeUnit.SelectedIndex = 0;
    }
    public void OnClickUnitChange(object sender, EventArgs e)
    {
        lblCircleUnit_0.Text = ((Picker)sender).SelectedItem.ToString() + " ^2";
        lblCircleUnit_1.Text = ((Picker)sender).SelectedItem.ToString();
        lblCircleUnit_2.Text = ((Picker)sender).SelectedItem.ToString() + " ^3";

    }

    public void OnClickCalculate(object sender, EventArgs e)
    {
        
        try
        {
            activeCircle.Radius = double.Parse(txtRadius.Text);
            activeCircle.OnClickCalculate();
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
            DisplayAlert("Invalid Input", "Numeric Input Only", "Ok");
            txtRadius.Text = "0";
        }
    }
    public void OnClickClear(object sender, EventArgs e)
    {
        txtRadius.Text = "0";
        activeCircle.Area = 0;
        activeCircle.Perimeter = 0;
        activeCircle.VolumeSphere = 0;
    }
}