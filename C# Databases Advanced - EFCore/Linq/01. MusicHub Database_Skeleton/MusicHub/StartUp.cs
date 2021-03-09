namespace MusicHub
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context = 
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            StringBuilder result = new StringBuilder();
            var albums = context
                        .Albums
                        .Where(p => p.ProducerId == producerId)
                        .Select(a => new
                        {
                            a.Name,
                            a.ReleaseDate,
                            ProducerName = a.Producer.Name,
                            AlbumSongs = a.Songs.Select(s => new
                            {
                                SongName = s.Name,
                                s.Price,
                                SongWriterName = s.Writer.Name,
                            })
                        })
                        .OrderByDescending(p => p.AlbumSongs.Sum(s => s.Price))
                        .ToList();

            foreach (var album in albums)
            {
                int count = 0;
                result.AppendLine($"-AlbumName: {album.Name}");
                result.AppendLine($"-ReleaseDate: {album.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)}");
                result.AppendLine($"-ProducerName: {album.ProducerName}");
                result.AppendLine($"-Songs:");
                foreach (var song in album.AlbumSongs.OrderByDescending(s => s.SongName).ThenBy(w => w.SongWriterName))
                {
                    result.AppendLine($"---#{++count}");
                    result.AppendLine($"---SongName: {song.SongName}");
                    result.AppendLine($"---Price: {song.Price:F2}");
                    result.AppendLine($"---Writer: {song.SongWriterName}");
                }
                result.AppendLine($"-AlbumPrice: {album.AlbumSongs.Sum(s => s.Price):F2}");
            }

            return result.ToString().Trim();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            StringBuilder result = new StringBuilder();

            var songs = context.Songs
                        .Select(s => new
                        {
                            SongName = s.Name,
                            Writer = s.Writer.Name,
                            Performer = s.SongPerformers.Select(p => p.Performer.FirstName + " " + p.Performer.LastName).FirstOrDefault(),
                            AlbumProducer = s.Album.Producer.Name,
                            s.Duration,
                        })
                        .ToList()
                        .Where(s => s.Duration.TotalSeconds > duration)
                        .OrderBy(s => s.SongName)
                        .ThenBy(s => s.Writer)
                        .ThenBy(s => s.Performer);

            int count = 0;
            foreach (var song in songs)
            {
                result.AppendLine($"-Song #{++count}");
                result.AppendLine($"---SongName: {song.SongName}");
                result.AppendLine($"---Writer: {song.Writer}");
                result.AppendLine($"---Performer: {song.Performer}");
                result.AppendLine($"---AlbumProducer: {song.AlbumProducer}");
                result.AppendLine($"---Duration: {song.Duration:c}");
            }
            
            return result.ToString().Trim();
        }
    }
}
