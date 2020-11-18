using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class HelloWorldTest
    {
        [Fact]
        public void Hello_world_test()
        {
            //given
            Dependency dependency = new Dependency();
            HelloWorld helloWorld = new HelloWorld(dependency);

            //when
            string actual = helloWorld.BeenCalled();

            //then
            Assert.Equal("Leave me alone.", actual);
        }

        [Fact]
        public void Should_be_mocked()
        {
            //given
            var mockDependencu = new Mock<Dependency>();
            mockDependencu.Setup(m => m.Say()).Returns("Hello World");
            HelloWorld helloWorld = new HelloWorld(mockDependencu.Object);

            //when
            string actual = helloWorld.BeenCalled();

            //then
            Assert.Equal("Hello World", actual);
        }

        [Fact]
        public void Should_return_1_given_1()
        {
            //given
            Dependency translator = new Dependency();
            HelloWorld helloWorld = new HelloWorld(translator);

            //when
            string actual = helloWorld.Tranlate(1);

            //then
            Assert.Equal("1", actual);
        }

        [Fact]
        public void Should_return_2_given_2()
        {
            //given
            Dependency translator = new Dependency();
            HelloWorld helloWorld = new HelloWorld(translator);

            //when
            string actual = helloWorld.Tranlate(2);

            //then
            Assert.Equal("2", actual);
        }
    }
}