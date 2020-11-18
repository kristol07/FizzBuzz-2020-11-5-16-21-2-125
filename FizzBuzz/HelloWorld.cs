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
            return count.ToString();
        }
    }
}
