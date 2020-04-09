using System;
using System.Collections.Generic;

namespace LB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it?\nMiddle Ages - 1\nModern Ages - 2");
            string answer = Console.ReadLine();
            Factory factory;
            try
            {
                if (int.Parse(answer) == 1)
                {
                    factory = new MedievalFactory();
                }
                else if (int.Parse(answer) == 2)
                {
                    factory = new ModernFactory();
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    throw new FormatException();
                }
                //Console.WriteLine("How many Infantrymen should we create?");
                //answer = Console.ReadLine();
                //int numOfInfantrymen = int.Parse(answer);
                //Console.WriteLine("How many Ships should we create?");
                //answer = Console.ReadLine();
                //int numOfShips = int.Parse(answer);

                //Infantryman[] infantrymen = new Infantryman[numOfInfantrymen];
                //for (int i = 0; i < numOfInfantrymen; i++)
                //    infantrymen[i] = factory.createInfantryman();

                //Ship[] ships = new Ship[numOfShips];
                //for (int i = 0; i < numOfShips; i++)
                //    ships[i] = factory.createShip();

                //foreach(var i in infantrymen)
                //{
                //    i.SayHello();
                //    i.Shoot();
                //}
                //foreach (var i in ships)
                //{
                //    i.SayHello();
                //    i.Move();
                //}
                //Warlord.getInstance().SayHello();

                //BurgerBuilder burgerBuilder = new BurgerBuilder();
                //ChequeBuilder chequeBuilder = new ChequeBuilder();

                //Director burgerDirector = new Director(burgerBuilder);

                //burgerDirector.CreateCheapThing();
                //Burger cheapBurger = burgerBuilder.GetResult();

                //burgerDirector.CreateExpensiveThing();
                //Burger expensiveBurger = burgerBuilder.GetResult();

                //Director chequeDirector = new Director(chequeBuilder);
                //chequeDirector.CreateCheapThing();
                //Cheque cheapCheque = chequeBuilder.GetResult();

                //chequeDirector.CreateExpensiveThing();
                //Cheque expensiveCheque = chequeBuilder.GetResult();

                //Console.WriteLine("Cheap burger:\n" + cheapBurger + "\nCheap cheque:\n" + cheapCheque +
                //    "\nExpensive burger:\n" + expensiveBurger + "\nExpensive cheque:\n" + expensiveCheque);


                //Prototype prototype = new Prototype("Petya", 20);
                //Console.WriteLine((Prototype)prototype.Clone());

                Ship ship = factory.createShip();
                //((Infantryman)ship).Shoot(); ошибка
                //var shipToInfantryman = new Adapter(ship);
                //shipToInfantryman.SayHello();
                //shipToInfantryman.Shoot();


                ship.Move();
                Console.WriteLine();
                //ship = new ShipAddSail(ship);
                //ship = new ShipAddRowers(ship);
                //ship = new ShipAddSail(ship);
                ship.LaunchShip();////
                ship.Move();


                Union platoon = new Union("Platoon"); //Взвод
                Union squad1 = new Union("Squad 1");
                Union squad2 = new Union("Squad 2");
                Union squad3 = new Union("Squad 3");
                squad1.AddComponent(factory.createInfantryman("Infantryman1_1"));
                squad1.AddComponent(factory.createInfantryman("Infantryman2_1"));
                squad1.AddComponent(factory.createShip("Ship1_1"));
                squad2.AddComponent(factory.createShip("Ship1_2"));
                squad2.AddComponent(factory.createShip("Ship2_2"));
                squad3.AddComponent(factory.createInfantryman("Infantryman1_3"));
                squad3.AddComponent(factory.createInfantryman("Infantryman2_3"));
                squad3.AddComponent(factory.createInfantryman("Infantryman3_3"));
                platoon.AddComponent(squad1);
                platoon.AddComponent(squad2);
                platoon.AddComponent(squad3);
                //Console.WriteLine("Введите название компонента для поиска: ");
                //string componentToFind = Console.ReadLine();
                //try
                //{
                //    platoon.Find(componentToFind).SayHello();
                //}
                //catch
                //{
                //    Console.WriteLine(componentToFind + " не найден!");
                //}
                Warlord.getInstance().command = new UnionSayHelloCommand(squad1);
                Warlord.getInstance().ExecuteCommand();

                Caretaker shipCaretaker = new Caretaker(ship);
                shipCaretaker.Backup();
                ship.RaiseShip();
                ship.Move();
                shipCaretaker.Undo();
                Console.WriteLine("Undo: ");
                ship.Move();
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("Введено не число!");
            }
           
        }
    }
    
    class Archer : Infantryman
    {
        public Archer(string name)
        {
            Title = name;
        }
        public Archer() { }
        public void Shoot()
        {
            Console.WriteLine("Archer shoots");
        }
        public void SayHello()
        {
            Console.WriteLine($"Archer {Title} greets you");
        }
        public String Title { get; set; }
        public IComponent Find(string title) => (Title == title) ? this : null;
    }
    class Shooter : Infantryman
    {
        public Shooter(string name)
        {
            Title = name;
        }
        public Shooter() { }
        public void Shoot()
        {
            Console.WriteLine("Shooter shoots");
        }
        public void SayHello()
        {
            Console.WriteLine($"Shooter {Title} greets you");
        }
        public String Title { get; set; }
        public IComponent Find(string title) => (Title == title) ? this : null;
    }
    class Sailboat : Ship
    {
        protected ShipState state = new ShipNotOnWater();
        public Sailboat(string name)
        {
            Title = name;
        }
        public Sailboat() { }
        public void Move()
        {
            //Console.WriteLine("Sailboat is sailing");
            state.Handle();
        }
        public void SayHello()
        {
            Console.WriteLine($"The crew of sailboat {Title} greets you");
        }
        public String Title { get; set; }
        public IComponent Find(string title) => (Title == title) ? this : null;

        public void LaunchShip() => state = new ShipOnWater();
        public void RaiseShip() => state = new ShipNotOnWater();

        public IMemento Save() => new ConcreteMemento(state);
        public void Restore(IMemento memento) => state = memento.GetState();
    }
    class Battleship : Ship
    { 
        protected ShipState state = new ShipNotOnWater();
        public void LaunchShip() => state = new ShipOnWater();
        public void RaiseShip() => state = new ShipNotOnWater();
        public Battleship(string name)
        {
            Title = name;
        }
        public Battleship() { }
        public void Move()
        {
            //Console.WriteLine("Battleship is sailing");
            state.Handle();
        }
        public void SayHello()
        {
            Console.WriteLine($"The crew of battleship {Title} greets you");
        }
        public String Title { get; set; }
        public IComponent Find(string title) => (Title == title) ? this : null;

        public IMemento Save() => new ConcreteMemento(state);
        public void Restore(IMemento memento) => state = memento.GetState();
    }



    interface Infantryman : IComponent
    {
        void Shoot();
        //void SayHello();
    }
    interface Ship : IComponent
    {
        //void SayHello();
        void Move();
        void LaunchShip();
        void RaiseShip();
        public IMemento Save();
        public void Restore(IMemento memento);
    }

    abstract class Factory
    {
        abstract public Infantryman createInfantryman();
        abstract public Ship createShip();
        abstract public Infantryman createInfantryman(string name);
        abstract public Ship createShip(string name);
    }
    class MedievalFactory : Factory
    {
        public override Infantryman createInfantryman()
        {
            return new Archer();
        }
        public override Ship createShip()
        {
            return new Sailboat();
        }
        public override Infantryman createInfantryman(string name)
        {
            return new Archer(name);
        }
        public override Ship createShip(string name)
        {
            return new Sailboat(name);
        }

    }
    class ModernFactory : Factory
    {
        public override Infantryman createInfantryman()
        {
            return new Shooter();
        }
        public override Ship createShip()
        {
            return new Battleship();
        }
        public override Infantryman createInfantryman(string name)
        {
            return new Shooter(name);
        }
        public override Ship createShip(string name)
        {
            return new Battleship(name);
        }
    }

    class Adapter : Infantryman
    {
        private Ship _instance;
        public Adapter(Ship instance) => _instance = instance;
        public void SetInstance(Ship instance) => _instance = instance;
        public void SayHello() => _instance.SayHello();
        public void Shoot() => Console.WriteLine("Ship can't shoot!");

        public String Title { get; set; }
        public IComponent Find(string title) => (Title == title) ? this : null;
    }

    abstract class ShipDecorator : Ship
    {
        protected Ship _instance;
        public void LaunchShip() => _instance.LaunchShip();
        public void RaiseShip() => _instance.RaiseShip();
        public ShipDecorator(Ship instance) => _instance = instance;
        public void SetShip(Ship instance) => _instance = instance;
        public void SayHello()
        {
            if (_instance != null)
                _instance.SayHello();
        }
        public virtual void Move()
        {
            if (_instance != null)
                _instance.Move();
        }
        public String Title { get; set; }
        public IComponent Find(string title) => (Title == title) ? this : null;

        public IMemento Save() => _instance.Save();
        public void Restore(IMemento memento) => _instance.Restore(memento);
    }

    class ShipAddSail : ShipDecorator
    {
        public ShipAddSail(Ship ship) : base(ship)
        { }
        public override void Move()
        {
            base.Move();
            Console.WriteLine(" + sails ");
        }
    }
    class ShipAddRowers : ShipDecorator
    {
        public ShipAddRowers(Ship ship) : base(ship)
        { }
        public override void Move()
        {
            base.Move();
            Console.WriteLine(" + rowers ");
        }
    }


    public interface IComponent
    {
        string Title { get; set; }
        IComponent Find(string title);
        void SayHello();
    }

    
    public class Union : IComponent
    {
        //public bool IsUnion() => true;
        public Union(string title) => Title = title;
        private readonly List<IComponent> _list = new List<IComponent>();
        public string Title { get; set; }
        public void AddComponent(IComponent component) => _list.Add(component);
        public void DeleteComponent(IComponent component) => _list.Remove(component);
        public IComponent Find(string title)
        {
            if (title == Title)
                return this;
            else
            {
                IComponent result = null;
                foreach (var i in _list)
                {
                    result = i.Find(title);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
        public void SayHello()
        {
            Console.WriteLine($"Union {Title} greets you!");
            foreach (var i in _list)
                i.SayHello();
        }
    }

    interface ICommand
    {
        void Execute();
    }
    class UnionSayHelloCommand : ICommand
    {
        private Union _instance;
        public UnionSayHelloCommand(Union union) => _instance = union;
        public void Execute() => _instance.SayHello();
    }
    class ComponentSayHelloCommand : ICommand
    {
        private IComponent _instance;
        public ComponentSayHelloCommand(Union union) => _instance = union;
        public void Execute() => _instance.SayHello();
    }


    abstract class ShipState
    {
        protected Ship context;
        public void SetContext(Ship context)
        {
            this.context = context;
        }
        public abstract void Handle();
    }
    class ShipNotOnWater : ShipState
    {
        public override void Handle() => Console.WriteLine("Ship can't move, it's not on water!");
    }
    class ShipOnWater : ShipState
    {
        public override void Handle() => Console.WriteLine("Ship moves!");
    }

    interface IMemento
    {
        ShipState GetState();
    }
    class ConcreteMemento : IMemento
    {
        private ShipState state;
        public ConcreteMemento(ShipState state) => this.state = state;
        public ShipState GetState() => state;
    }
    class Caretaker
    {
        private Ship originator;
        private IMemento memento;
        public Caretaker(Ship originator) => this.originator = originator;
        public void Backup() => memento = originator.Save();
        public void Undo()
        {
            if (memento != null)
                originator.Restore(memento);
        }
    }
}
