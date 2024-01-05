using webAPINextJS.Api.Dtos;
using webAPINextJS.Api.Services;

namespace webAPINextJs.Tests;

public class BookKeeperTests
{
    [Fact]
    public void should_return_OK()
    {
        var instance = new BookKeeper();
        var request = new BookRequest("Brandon Sanderson", "Mistborn", 2008);

        instance.CreateBook(request);
        
    }
}