using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace week_4_code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Movie> movieList;
        public MainWindow()
        {
            InitializeComponent();
            movieList = new ObservableCollection<Movie>();
            lvMovies.ItemsSource = movieList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Movie movie = new Movie(titleInput.Text, Convert.ToInt32(ReleaseInput.Text), Convert.ToDouble(TomatoesInput.Text));
            //Movie selectedMovie = lvMovies.SelectedItem as Movie;
            foreach (Movie m in movieList)
            {
                if (movie.Title == m.Title)
                {
                    MessageBox.Show("no you have");
                    return;
                }
            }
            movieList.Add(movie);
            titleInput.Clear();
            ReleaseInput.Clear();
            TomatoesInput.Clear();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
           foreach (Movie movie in movieList)
            {
                movie.ShowDetails();

            }
        }
        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
                
            }
        }

    }
}
