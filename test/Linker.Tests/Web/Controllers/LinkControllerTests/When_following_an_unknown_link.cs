using FluentAssertions;
using Linker.Model;
using Linker.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

namespace Linker.Tests
{
    public class When_following_an_unknown_link
    {
        [Fact]
        public void Should_return_an_http_not_found_result()
        {
            var sut = new LinkController(
                Substitute.For<IRetrieveLinks>(),
                Substitute.For<ISaveLinks>());

            var result = sut.Follow("unknown-link-id");

            result.Should().BeOfType<NotFoundResult>();
        }
    }
}
