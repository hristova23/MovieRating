namespace MovieRating.ViewModels;

public partial class MoviesViewModel : BaseViewModel
{
    public ObservableCollection<Movie> Movies { get; } = new ObservableCollection<Movie>()
    {
        new Movie(){Name= "Predestination", Description = "", Rating = 3},
        new Movie(){Name= "Inception", Description = "", Rating = 4},
        new Movie(){Name= "It 2", Description = "", Rating = 2},
        new Movie(){Name= "The Fringe", Description = "", Rating = 5}
    };

    public MoviesViewModel()
    {
        Title = "Movie Library";
    }
}