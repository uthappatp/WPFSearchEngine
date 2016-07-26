using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSearchProvider
{
    public interface ICustomSearch
    {
        Task<IList<SearchStory>> GetSearchStories(string searchKey);
    }
}
