namespace MSSearchProvider
{
    public interface ISearchProvider
    {
        ICustomSearch GetSearchProviderService(string providerName);
    }
}
