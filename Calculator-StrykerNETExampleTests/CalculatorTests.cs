using Calculator_StrykerNETExample;
using FluentAssertions;

namespace Calculator_StrykerNETExampleTests
{
    public class CalculatorTests
    {
        private readonly Calculator _subject;

        public CalculatorTests()
        {
            _subject = new Calculator();
        }

        [Theory]
        [InlineData(5, 5, 10)]
        public void Add_WhenValuesAreAdded_ThenCorrectResponseIsReturned(int value1, int value2, int expectedResult)
        {
            // arrange
            
            // act
            var result = _subject.Add(value1, value2);
            
            // assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void Subtract_WhenValuesAreSubtracted_ThenCorrectResponseIsReturned(int value1, int value2, int expectedResult)
        {
            // arrange

            // act
            var result = _subject.Subtract(value1, value2);

            // assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(2, 3, 6)]
        [InlineData(2, 5, 10)]
        public void Multiply_WhenValuesAreMultiplied_ThenCorrectResponseIsReturned(int value1, int value2, int expectedResult)
        {
            // arrange

            // act
            var result = _subject.Multiply(value1, value2);

            // assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(1, 1, 1, 0)]
        [InlineData(10, 2, 5, 0)]
        [InlineData(25, 4, 6, 1)]
        public void Divide_WhenValuesAreDivided_ThenCorrectResponseIsReturned(int value1, int value2, int expectedResult, int expectedRemainder)
        {
            // arrange

            // act
            var (result, remainder) = _subject.Divide(value1, value2);

            // assert
            result.Should().Be(expectedResult);
            remainder.Should().Be(expectedRemainder);
        }

        [Fact]
        public void Divide_WhenDividedByZero_ThenExceptionIsThrown()
        {
            // arrange

            // act
            _subject
                .Invoking(s => s.Divide(1, 0))
                .Should().Throw<DivideByZeroException>();

            // assert
        }
    }
}