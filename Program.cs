using System;


using System;
using System.Collections.Generic;

class MusicComposition
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public string Genre { get; set; }
    public string Duration { get; set; }
}

class MusicLibrary
{
    private List<MusicComposition> compositions = new List<MusicComposition>();

    public void AddComposition(MusicComposition composition)
    {
        compositions.Add(composition);
    }

    public void SortByGenreAndDuration()
    {
        compositions.Sort((a, b) =>
        {
            int genreComparison = a.Genre.CompareTo(b.Genre);
            if (genreComparison != 0)
            {
                return genreComparison;
            }
            else
            {
                return a.Duration.CompareTo(b.Duration);
            }
        });
    }
    public List<MusicComposition> GetCompositionsByArtist(string artist)
    {
        return compositions.FindAll(Findart => Findart.Artist == artist);
    }

    class Program
    {
        static void Main(string[] args)
        {
            MusicLibrary library = new MusicLibrary();
            library.AddComposition(new MusicComposition
            {
                Title = "Bohemian Rhapsody",
                Artist = "Queen",
                Album = "A Night at the Opera",
                Genre = "Rock",
                Duration = "5:54"
            });
            library.AddComposition(new MusicComposition
            {
                Title = "This dream",
                Artist = "Stepan Giga",
                Album = "Without album",
                Genre = "Ballade",
                Duration = "3:14"
            });
            library.AddComposition(new MusicComposition
            {
                Title = "Carpathian gold",
                Artist = "Stepan Giga",
                Album = "The road to the temple",
                Genre = "Civic lyrics",
                Duration = "4:17"
            });
            library.AddComposition(new MusicComposition
            {
                Title = "In heaven",
                Artist = "Sviatoslav Vakarchuk",
                Album = "Earth",
                Genre = "Rock",
                Duration = "3:42"

            });
            library.SortByGenreAndDuration();


            List<MusicComposition> compositionsBySG = library.GetCompositionsByArtist("Stepan Giga");
            Console.WriteLine("Compositions by Stepan Giga:");
            foreach (var composition in compositionsBySG)
            {
                Console.WriteLine("{0} - {1}", composition.Title, composition.Album);
            }


            Console.ReadKey();


        }
    }
}