using System;

namespace FizzBuzz
{
    public class HelloWorld
    {
        private readonly Dependency dependency;

        public HelloWorld(Dependency dependency)
        {
            this.dependency = dependency;
        }

        public string BeenCalled()
        {
            return dependency.Say();
        }

        public string Tranlate(int count)
        {
            if (count % 3 == 0 && count % 5 == 0 && count % 7 == 0)
            {
                return "FizzBuzzWhizz";
            }

            if (count % 3 == 0 && count % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (count % 3 == 0)
            {
                return "Fizz";
            }

            if (count % 5 == 0)
            {
                return "Buzz";
            }

            if (count % 7 == 0)
            {
                return "Whizz";
            }

            return count.ToString();
        }
    }
}
