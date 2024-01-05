using webAPINextJS.Api.Dtos;

namespace webAPINextJS.Api.Services;

public interface IBookKeeper
{
    void CreateBook(BookRequest request);
    // Dictionary<string, List<string>> RetrieveBooks();
}
