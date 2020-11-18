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
            if (count % 3 == 0)
            {
                return "Fizz";
            }

            return count.ToString();
        }
    }
}
