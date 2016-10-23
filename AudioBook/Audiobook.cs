using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace AudioBook
{
    class Audiobook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Narrator { get; set; }
        public TimeSpan TotalTime { get; set; }
        private MediaPlaybackList trackList;

        public Audiobook(MediaPlaybackList tracks)
        {
            trackList = tracks;
            MediaItemDisplayProperties displayProps = trackList.CurrentItem.GetDisplayProperties();
            if (MediaPlaybackType.Music == displayProps.Type)
            {
                Title = displayProps.MusicProperties.AlbumTitle;
                Author = displayProps.MusicProperties.AlbumArtist;
                while (null != trackList.CurrentItem)
                {
                    TotalTime.Add(trackList.CurrentItem.DurationLimit.Value);
                    trackList.MoveNext();
                }
            }
        }



    }
}
