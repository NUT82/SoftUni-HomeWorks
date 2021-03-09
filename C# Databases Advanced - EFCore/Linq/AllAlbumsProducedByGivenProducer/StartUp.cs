using MusicHub.Data;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace AllAlbumsProducedByGivenProducer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MusicHubDbContext musicHubDbContext = new MusicHubDbContext();

            int producerId = int.Parse(Console.ReadLine());
            Console.WriteLine(ExportAlbumsInfo(musicHubDbContext, producerId));
        }

        private static string ExportAlbumsInfo(MusicHubDbContext musicHubDbContext, int producerId)
        {
            StringBuilder result = new StringBuilder();
            var albums = musicHubDbContext
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
                            .OrderByDescending(s => s.SongName)
                            .ThenBy(w => w.SongWriterName),
                            AlbumPrice = a.Songs.Sum(s => s.Price),
                        })
                        .OrderByDescending(p => p.AlbumPrice)
                        .ToList();

            foreach (var album in albums)
            {
                int count = 0;
                result.AppendLine($"-AlbumName: {album.Name}");
                result.AppendLine($"-ReleaseDate: {album.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)}");
                result.AppendLine($"-ProducerName: {album.ProducerName}");
                result.AppendLine($"-Songs:");
                foreach (var song in album.AlbumSongs)
                {
                    result.AppendLine($"---#{++count}");
                    result.AppendLine($"---SongName: {song.SongName}");
                    result.AppendLine($"---Price: {song.Price:F2}");
                    result.AppendLine($"---Writer: {song.SongWriterName}");
                }
                result.AppendLine($"-AlbumPrice: {album.AlbumPrice:F2}");
            }

            return result.ToString();
        }
    }
}
