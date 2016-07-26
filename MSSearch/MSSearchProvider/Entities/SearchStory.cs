using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSearchProvider
{
    public class SearchStory 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Site { get; set; }
        public Uri HrefLink { get; set; }
        public string Image { get; set; }
        public string PublishedDate { get; set; }
    }
}
