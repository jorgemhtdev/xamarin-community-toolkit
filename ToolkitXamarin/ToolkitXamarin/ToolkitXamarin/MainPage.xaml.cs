namespace ToolkitXamarin
{
    using System;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Tapped_Behaviors(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new BehaviorsExampleView());
        }

        async void Tapped_Converter(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConverterExampleView());
        }
    }
}
