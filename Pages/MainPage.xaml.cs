namespace MovieRating.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MoviesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}