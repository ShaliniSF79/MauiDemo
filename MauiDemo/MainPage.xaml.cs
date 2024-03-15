namespace MauiDemo
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Grid Tapped", "You tapped the grid!", "OK");
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            await DisplayAlert("Label Tapped", "You tapped the Label!", "OK");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Button Tapped", "You tapped the Button!", "OK");
        }
    }

}
