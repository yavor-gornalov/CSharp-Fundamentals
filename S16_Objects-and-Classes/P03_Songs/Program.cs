internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PlayList myPlayList = new PlayList();

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split("_")
                .ToArray();
            string typeList = tokens[0];
            string name = tokens[1];
            string time = tokens[2];

            Song newSong = new Song(typeList, name, time);

            myPlayList.AddSong(newSong);
        }

        string filter = Console.ReadLine();
        myPlayList.DisplaySongsByListType(filter);
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }

        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Title = name;
            Duration = time;
        }
        public void PrintSongTitle()
        {
            Console.WriteLine(Title);
        }
    }

    public class PlayList
    {
        public List<Song> Songs= new List<Song>();

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void DisplaySongsByListType(string listType)
        {
            if (listType == "all")
            {
                foreach (Song song in Songs)
                {
                    song.PrintSongTitle();
                }
                return;
            }
            foreach (Song song in Songs.Where(x => x.TypeList == listType))
            {
                song.PrintSongTitle();
            }
        }
    }
}
