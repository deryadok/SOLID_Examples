namespace _03_LiskovSubstitution.Ducks.Refactored
{
    public interface IFly
    {
        void Fly();
    }

    public interface ISwim
    {
        void Swim();
    }

    public interface IQuack
    {
        void Quack();
    }

    public class MallardDuck : IFly, ISwim, IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            System.Console.WriteLine("Swimming!");
        }

        public void Fly()
        {
            System.Console.WriteLine("Flying!");
        }
    }

    public class MarbledDuck : IFly, ISwim, IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack!");
        }

        public void Swim()
        {
            System.Console.WriteLine("Swimming!");
        }

        public void Fly()
        {
            System.Console.WriteLine("Flying!");
        }
    }

    public class RubberDuck : ISwim, IQuack
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak!");
        }

        public void Swim()
        {
            System.Console.WriteLine("Floating!");
        }
    }
}
