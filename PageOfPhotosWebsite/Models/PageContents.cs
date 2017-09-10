using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageOfPhotosWebsite.Models
{
    public class PageContents
    {
        public PageRef pageRef { get; set; }

        public List<PageItem> PageItems { get; set; }
    }
}

