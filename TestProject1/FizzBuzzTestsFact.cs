using System.Buffers.Text;
using System.Threading;
using FizzBuzz;
using FizzBuzzGame;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
    public class FizzBuzzTestsFact
    {

        [Fact]
        public void It_Is_Playable_With_Three()
        {
            var num = 3;
            var expected = "Fizz";
            var fizzbuzz = new FizzBuzz.FizzBuzz();

            var actual = fizzbuzz.ThreeAcceptance(num);

            actual.Should().Be(expected);


        }
        [Fact]
        public void It_Is_Not_Playable_With_Three_Exepction()
        {

            var num = 2;
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var actual = () => fizzBuzz.ThreeAcceptance(num);

            actual.Should().ThrowExactly<ItIsNotPlayableWithThreeExepction>();

        }



        [Fact]

        public void It_Is_Playable_With_Five()
        {

            var num = 5;
            var expected = "Buzz";
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var actual = fizzBuzz.FiveAcceptance(num);


            actual.Should().Be(expected);
        }

        [Fact]
        public void It_Is_Not_Playable_With_Five_Exepction()
        {

            var num = 6;
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var actual = () => fizzBuzz.FiveAcceptance(num); ;

            actual.Should().ThrowExactly<ItIsNotPlayableWithFiveExepction>();

        }


        [Fact]

        public void It_Is_Playable_With_Five_And_Three()
        {

            var num = 15;
            var expected = "FizzBuzz";
            var fizzBuzz = new FizzBuzz.FizzBuzz();


            var actual = fizzBuzz.FiveAndThreeAcceptance(num);


            actual.Should().Be(expected);
        }
        [Fact]
        public void It_Is_Not_Playable_With_Three_And_Five_Exepction()
        {

            var num = 19;
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var actual = () => fizzBuzz.FiveAndThreeAcceptance(num);

            actual.Should().ThrowExactly<ItIsNotPlayableWithFiveAndThreeExepction>();

        }

       

    }
}