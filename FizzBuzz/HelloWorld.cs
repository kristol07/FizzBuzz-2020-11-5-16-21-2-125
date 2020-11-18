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
            string word = string.Empty;

            if (count % 3 == 0)
            {
                word += "Fizz";
            }

            if (count % 5 == 0)
            {
                word += "Buzz";
            }

            if (count % 7 == 0)
            {
                word += "Whizz";
            }

            return word.Length == 0 ? count.ToString() : word;
        }
    }
}
