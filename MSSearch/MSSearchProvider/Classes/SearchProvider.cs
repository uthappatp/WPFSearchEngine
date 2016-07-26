

namespace MSSearchProvider
{
    public class SearchProvider : ISearchProvider
    {
        public ICustomSearch GetSearchProviderService(string providerName)
        {
            return new WebHoseSearchProvider();
        }
    }
}
