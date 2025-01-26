using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NFT.UseCases.NftItem.Commands;
using Xunit;

public class CreateNftCommandPerformanceTests
{
    [Fact]
    public async Task CreateNftCommandHandler_ShouldHandle1000RequestsUnder1Second()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "PerformanceTestDb")
            .Options;
        var context = new AppDbContext(options);

        var handler = new CreateNftCommandHandler(context);
        var command = new CreateNftCommand(new Shared.DataTransferObjects.NftItem.NftItemDto
        {
            UserId = Guid.NewGuid(),
            Name = "Performance NFT",
            Hash = "HASH123",
            Price = 100m,
            IsListed = true,
            CollectionId = Guid.NewGuid()
        });

        var stopwatch = new Stopwatch();

        // Act
        stopwatch.Start();
        for (int i = 0; i < 1000; i++)
        {
            await handler.Handle(command, CancellationToken.None);
        }
        stopwatch.Stop();

        // Assert
        Assert.True(stopwatch.ElapsedMilliseconds < 1000, $"Performance test failed. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
    }
}
