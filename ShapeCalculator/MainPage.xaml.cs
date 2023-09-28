﻿namespace ShapeCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClickOpenPage(object sender, EventArgs e)
        {
            int pageBtnId = Int32.Parse(((Button)sender).AutomationId);
            if (pageBtnId == 0) //Rectangle
            {
                Shell.Current.GoToAsync("RectangleViewModel");
            }
            else if(pageBtnId == 1) // Square
            {
                Shell.Current.GoToAsync("SquareView");
            }else if(pageBtnId == 2) // Triangle
            {
                Shell.Current.GoToAsync("TriangleView");
            }else if (pageBtnId==3) // Circle
            {
                Shell.Current.GoToAsync("CircleViewModel");
            }
        }
    }
}