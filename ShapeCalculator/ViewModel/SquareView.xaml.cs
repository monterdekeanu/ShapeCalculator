using ShapeCalculator.Model;
namespace ShapeCalculator.ViewModel;

public partial class SquareView : ContentPage
{
	public SquareModel activeSquare { get; set; }
	public SquareView()
	{
		InitializeComponent();
		this.BindingContext = activeSquare = new SquareModel();
		activeUnit.SelectedIndex = 0;
	}

    public void OnClickUnitChange(object sender, EventArgs e)
    {
		lblSquareUnit_0.Text = ((Picker)sender).SelectedItem.ToString() + " ^2";
        lblSquareUnit_1.Text = ((Picker)sender).SelectedItem.ToString();
        lblSquareUnit_2.Text = ((Picker)sender).SelectedItem.ToString() + " ^3";

    }

	public void OnClickCalculate(object sender, EventArgs e)
	{
        try
        {
            activeSquare.Side = double.Parse(txtSide.Text);
            activeSquare.OnClickCalculate();
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
            DisplayAlert("Invalid Input", "Numeric Input Only", "Ok");
            txtSide.Text = "0";
        }

    }
	public void OnClickClear(object sender, EventArgs e)
	{
        txtSide.Text = "0";
        activeSquare.Area = 0;
        activeSquare.Perimeter = 0;
        activeSquare.Volume = 0;
    }
}