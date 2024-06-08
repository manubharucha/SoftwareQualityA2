using NUnit.Framework;
using Assignment2_group12;
using System;

namespace Assignment2_group12.Tests
{
    [TestFixture]
    public class ProductTest
    {
       
        [Test] // Test for ProductID with a valid ID
        public void ProductID_WithValidID_ReturnsCorrectID()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 100);

            // Act
            var result = product.ProductID;

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test] // Test for ProductID with the maximum value
        public void ProductID_WithMaxValue_ReturnsMaxValue()
        {
            // Arrange
            var product = new Product(40000, "Book", 10.0m, 100);

            // Act
            var result = product.ProductID;

            // Assert
            Assert.That(result, Is.EqualTo(40000));
        }

        [Test] // Test for ProductID with the minimum value
        public void ProductID_WithMinValue_ReturnsMinValue()
        {
            // Arrange
            var product = new Product(4, "Book", 10.0m, 100);

            // Act
            var result = product.ProductID;

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test] // Test for ProductName with a valid name
        public void ProductName_WithValidName_ReturnsCorrectName()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 100);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result, Is.EqualTo("Book"));
        }

        [Test] // Test for ProductName with an invalid name (null)
        public void ProductName_WithNullName_ReturnsNull()
        {
            // Arrange
            var product = new Product(1, null, 10.0m, 100);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result, Is.Null);
        }


        [Test] // Test for ProductName with an empty string
        public void ProductName_WithEmptyName_ReturnsEmptyString()
        {
            // Arrange
            var product = new Product(1, "", 10.0m, 100);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result, Is.EqualTo(""));
        }

        [Test] // Test for ProductName with special characters
        public void ProductName_WithSpecialCharacters_ReturnsSpecialCharacters()
        {
            // Arrange
            var product = new Product(1, "Book ##", 10.0m, 100);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result, Is.EqualTo("Book ##"));
        }


        [Test] // Test for Price with a valid price
        public void Price_WithValidPrice_ReturnsCorrectPrice()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 100);

            // Act
            var result = product.Price;

            // Assert
            Assert.That(result, Is.EqualTo(10.0m));
        }

        [Test] // Test for Price with the maximum value
        public void Price_WithMaxValue_ReturnsMaxValue()
        {
            // Arrange
            var product = new Product(1, "Book", 4000.0m, 100);

            // Act
            var result = product.Price;

            // Assert
            Assert.That(result, Is.EqualTo(4000.0m));
        }

        [Test]  // Test for Price with the minimum value
        public void Price_WithMinValue_ReturnsMinValue()
        {
            // Arrange
            var product = new Product(1, "Book", 4.0m, 100);

            // Act
            var result = product.Price;

            // Assert
            Assert.That(result, Is.EqualTo(4.0m));
        }

        
        [Test] // Test for Stock with a valid stock value
        public void Stock_WithValidStock_ReturnsCorrectStock()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 100);

            // Act
            var result = product.Stock;

            // Assert
            Assert.That(result, Is.EqualTo(100));
        }

        [Test] // Test for Stock with the maximum value
        public void Stock_WithMaxValue_ReturnsMaxValue()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 400000);

            // Act
            var result = product.Stock;

            // Assert
            Assert.That(result, Is.EqualTo(400000));
        }

        [Test] // Test for Stock with the minimum value
        public void Stock_WithMinValue_ReturnsMinValue()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 4);

            // Act
            var result = product.Stock;

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test] // Test for increasing stock by a valid amount
        public void IncreaseStock_WithValidAmount_IncreasesStock()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 100);

            // Act
            product.IncreaseStock(50);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(150));
        }

        [Test] // Test for increasing stock with multiple increments
        public void IncreaseStock_WithMultipleIncrements_IncreasesStockAccurately()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 100);

            // Act
            product.IncreaseStock(20);
            product.IncreaseStock(30);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(150));
        }

        [Test] // Test for increasing stock at the maximum boundary
        public void IncreaseStock_AtMaxBoundary_IncreasesStock()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 400000);

            // Act
            product.IncreaseStock(1);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(400001));
        }

        [Test] // Test for decreasing stock by a valid amount
        public void DecreaseStock_WithValidAmount_DecreasesStock()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 100);

            // Act
            product.DecreaseStock(50);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(50));
        }

       [Test] // Test for decreasing stock to zero
        public void DecreaseStock_ToExactStock_DecreasesToZero()
        {
            // Arrange
            var product = new Product(1, "Book", 10.0m, 50);

            // Act
            product.DecreaseStock(50);

            // Assert
            Assert.That(product.Stock, Is.EqualTo(0));
        }

        [Test] // Test for getting the correct price
        public void ProductPrice_GivenPriceIs3_99_ShouldReturnCorrectPrice()
        {
            // Arrange
            decimal input_value = 3.99m;
            var product = new Product(45, "Book", input_value, 476);

            // Act
            decimal actual_result = product.Price;

            // Assert
            Assert.That(actual_result, Is.EqualTo(input_value));
        }

        [Test] // Test for getting the correct ProductID
        public void ProductID_GivenProductIDIs45_ShouldReturnCorrectID()
        {
            // Arrange
            int input_value = 45;
            var product = new Product(input_value, "Book", 3.99m, 476);

            // Act
            int actual_result = product.ProductID;

            // Assert
            Assert.That(actual_result, Is.EqualTo(input_value));
        }

    }
}