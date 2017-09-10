using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageOfPhotosWebsite.Models
{
    public class PageItem
    {
        public string PhotoThumbUrl { get; set; }
        public string PhotoFullUrl { get; set; }
        public string PhotoName { get; set; }
        public string PhotoDescription { get; set; }
    }
}
