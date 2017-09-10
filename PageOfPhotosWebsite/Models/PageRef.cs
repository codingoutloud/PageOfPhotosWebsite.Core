using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageOfPhotosWebsite.Models
{
    public class PageRef
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserAvatarUrl { get; set; }
    }
}