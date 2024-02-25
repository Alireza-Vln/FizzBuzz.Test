using FizzBuzzGame;

namespace FizzBuzz
{
    public class FizzBuzz
    {

        public string FizzBuzzTheoryMode(double num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {

                return "FizzBuzz";
            }
            else
            if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            if (num % 3 == 0 )
            {
                return "Fizz";
            }
            else 
            {
                throw new ItIsNotPlayableWithFiveAndThreeExepction();
            }
        }





        public string FiveAcceptance(int num)
        {
            if (num % 5 != 0)
            {
                throw new ItIsNotPlayableWithFiveExepction();

            }

            return "Buzz";
        }

        public string FiveAndThreeAcceptance(int num)
        {
            if (num % 5 != 0 && num % 3 != 0)
            {

                throw new ItIsNotPlayableWithFiveAndThreeExepction();

            }

            return "FizzBuzz";
        }

        public string ThreeAcceptance(double num)
        {


            if (num % 3 != 0)
            {
                throw new ItIsNotPlayableWithThreeExepction();

            }

            return "Fizz";

        }
    }
}