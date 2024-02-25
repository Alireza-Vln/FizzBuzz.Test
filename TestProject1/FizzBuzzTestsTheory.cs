using FizzBuzzGame;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz.Unit.Test
{
    public class FizzBuzzTestsTheory
    {
        [Theory]
        [InlineData("FizzBuzz", 30)]
        [InlineData("Buzz", 5)]
        [InlineData("Fizz", 3)]
        public void Number_that_is_based_on_three_and_five_parts_of_acceptance(string expected, double num)
        {
            var fizzbuzz = new FizzBuzz();

            var actual = fizzbuzz.FizzBuzzTheoryMode(num);


            actual.Should().Be(expected);
        }


        [Fact]
        public void It_Is_Not_Playable_With_Three_And_Five_Exepction_for_theory_mode()
        {
            var num = 19;
            var fizzBuzz = new FizzBuzz();

            var actual = () => fizzBuzz.FizzBuzzTheoryMode(num);

            actual.Should().ThrowExactly<ItIsNotPlayableWithFiveAndThreeExepction>();
        }

    }
}
