using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPCWare.BlazorNasa.Models
{
    public class NasaImageInfo
    {
        public string Copyright { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string Hdurl { get; set; }
        public string Media_type { get; set; }
        public string Service_version { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}

/*
 * 
  "copyright": "Hubble Legacy Archive", 
  "date": "2017-07-12", 
  "explanation": "A bright spiral galaxy of the northern sky, Messier 63 is about 25 million light-years distant in the loyal constellation Canes Venatici. Also cataloged as NGC 5055, the majestic island universe is nearly 100,000 light-years across. That's about the size of our own Milky Way Galaxy. Known by the popular moniker, The Sunflower Galaxy, M63 sports a bright yellowish core in this sharp composite image from space- and ground-based telescopes. Its sweeping blue spiral arms are streaked with cosmic dust lanes and dotted with pink star forming regions. A dominant member of a known galaxy group, M63 has faint, extended features that are likely star streams from tidally disrupted satellite galaxies. M63 shines across the electromagnetic spectrum and is thought to have undergone bursts of intense star formation.", 
  "hdurl": "https://apod.nasa.gov/apod/image/1707/M63-HST-Subaru-LL.jpg", 
  "media_type": "image", 
  "service_version": "v1", 
  "title": "Messier 63: The Sunflower Galaxy", 
  "url": "https://apod.nasa.gov/apod/image/1707/M63-HST-Subaru-S1024.jpg"

*/