using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace TestApi.IntegrationTests;

public class TestControllerTests : IClassFixture<WebApplicationFactory<Startup>>
{
    readonly HttpClient _client;

    public TestControllerTests(WebApplicationFactory<Startup> application)
    {
        _client = application.CreateClient();
    }
    
    [Fact]
    public async Task GET_test()
    {
        var response = await _client.GetAsync("/");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
    
    [Fact]
    public async Task POST_test()
    {
        var response = await _client.PostAsync("/", null);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}