using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace week_4_code
{
    class Movie
    {
        public string Title { get; set;}
        public int ReleaseYear { get; set; }
        public double RottenTomatoes { get; set; }
    
        public Movie(string myTitle, int myReleaseYear, double myRottenTomatoes)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.RottenTomatoes = myRottenTomatoes;
        }
        public void ShowDetails()
        {
            string info = "Title:" + this.Title;
            info += "\nRelease Year: " + this.ReleaseYear;
            info += "\nRotten Tomatoes: " + this.RottenTomatoes;

            MessageBox.Show(info);
        }
    }
}
