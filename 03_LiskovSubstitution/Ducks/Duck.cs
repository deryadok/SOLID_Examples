namespace _03_LiskovSubstitution.Ducks
{
    public abstract class Duck
    {
        public abstract void Quack();
        public abstract void Swim();
        public abstract void Fly();
    }

    public class MallardDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming!");
        }

        public override void Fly()
        {
            Console.WriteLine("Flying!");
        }
    }

    public class MarbledDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming!");
        }

        public override void Fly()
        {
            Console.WriteLine("Flying!");
        }
    }

    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Squeak!");
        }

        public override void Swim()
        {
            Console.WriteLine("Floating!");
        }

        public override void Fly()
        {
            throw new NotImplementedException("Rubber ducks cannot fly!");
        }
    }
}
