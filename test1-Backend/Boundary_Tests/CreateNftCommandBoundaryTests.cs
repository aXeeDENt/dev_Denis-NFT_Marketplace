using System;
using FluentValidation;
using NFT.UseCases.NftItem.Commands;
using Xunit;

public class CreateNftCommandBoundaryTests
{
    [Fact]
    public void CreateNftCommandValidator_ShouldPass_WhenAllValuesAreValid()
    {
        // Arrange
        var validator = new CreateNftCommandValidator();
        var command = new CreateNftCommand(new Shared.DataTransferObjects.NftItem.NftItemDto
        {
            UserId = Guid.NewGuid(),
            Name = "Valid NFT",
            Hash = "123ABC",
            Price = 0.01m,
            IsListed = true,
            CollectionId = Guid.NewGuid()
        });

        // Act
        var result = validator.Validate(command);

        // Assert
        Assert.True(result.IsValid);
    }

    [Fact]
    public void CreateNftCommandValidator_ShouldFail_WhenPriceIsZero()
    {
        // Arrange
        var validator = new CreateNftCommandValidator();
        var command = new CreateNftCommand(new Shared.DataTransferObjects.NftItem.NftItemDto
        {
            UserId = Guid.NewGuid(),
            Name = "Test NFT",
            Hash = "123ABC",
            Price = 0m,
            IsListed = false,
            CollectionId = Guid.NewGuid()
        });

        // Act
        var result = validator.Validate(command);

        // Assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "Price" && e.ErrorMessage.Contains("cannot be empty"));
    }

    [Fact]
    public void CreateNftCommandValidator_ShouldFail_WhenHashIsEmpty()
    {
        // Arrange
        var validator = new CreateNftCommandValidator();
        var command = new CreateNftCommand(new Shared.DataTransferObjects.NftItem.NftItemDto
        {
            UserId = Guid.NewGuid(),
            Name = "Test NFT",
            Hash = string.Empty,
            Price = 100m,
            IsListed = true,
            CollectionId = Guid.NewGuid()
        });

        // Act
        var result = validator.Validate(command);

        // Assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "Hash" && e.ErrorMessage.Contains("cannot be empty"));
    }
}
