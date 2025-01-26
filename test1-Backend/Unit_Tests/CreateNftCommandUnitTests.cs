using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Moq;
using NFT.UseCases.NftItem.Commands;
using Xunit;

public class CreateNftCommandUnitTests
{
    [Fact]
    public async Task CreateNftCommandHandler_ShouldReturnGuid_WhenDataIsValid()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "UnitTestDb")
            .Options;
        var context = new AppDbContext(options);

        var handler = new CreateNftCommandHandler(context);
        var command = new CreateNftCommand(new Shared.DataTransferObjects.NftItem.NftItemDto
        {
            UserId = Guid.NewGuid(),
            Name = "Test NFT",
            Hash = "123456",
            Price = 100m,
            IsListed = true,
            CollectionId = Guid.NewGuid()
        });

        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.NotEqual(Guid.Empty, result);
        Assert.Single(context.NftItems);
    }

    [Fact]
    public void CreateNftCommandValidator_ShouldThrowException_WhenUserIdIsEmpty()
    {
        // Arrange
        var validator = new CreateNftCommandValidator();
        var command = new CreateNftCommand(new Shared.DataTransferObjects.NftItem.NftItemDto
        {
            UserId = Guid.Empty,
            Name = "Invalid NFT",
            Hash = "123456",
            Price = 100m,
            IsListed = true,
            CollectionId = Guid.NewGuid()
        });

        // Act & Assert
        var result = validator.Validate(command);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "UserId" && e.ErrorMessage.Contains("cannot be empty"));
    }
}
