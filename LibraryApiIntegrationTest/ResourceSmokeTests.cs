using LibraryApi;
using LibraryApiIntegrationTests;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryApiIntegrationTest
{
    public class ResourceSmokeTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient Client;
        public ResourceSmokeTests(CustomWebApplicationFactory<Startup> factory)
        {
            Client = factory.CreateClient();
        }

        [Theory]
        [InlineData("/books")]
        [InlineData("/books/1")]
        public async Task CheckIfResourceIsAlive(string resource)
        {
            var response = await Client.GetAsync(resource);
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task CanGetABook()
        {
            var response = await Client.GetAsync("/books/1");
            var book = await response.Content.ReadAsAsync<BookDetailsResponse>();
            Assert.Equal(1, book.id);
            Assert.Equal("Walden", book.title);
            Assert.Equal("Philosophy", book.genre);
        }


        public class BookDetailsResponse
        {
            public int id { get; set; }
            public string title { get; set; }
            public string author { get; set; }
            public string genre { get; set; }
            public int numberOfPages { get; set; }
        }
    }
}
