using System;
using System.Collections.Generic;
using System.Text;

namespace LB1
{
    interface IBuilder
    {
        IBuilder AddCotlet();
        IBuilder AddTomatoes();
        IBuilder AddCucumbers();
        IBuilder AddCheese();
        IBuilder AddCabbage();
        IBuilder AddPepper();
        IBuilder AddBun();
    }

    class Burger
    {
        public int cotlet { get; set; } = 0;
        public int tomatoes { get; set; } = 0;
        public int cucumbers { get; set; } = 0;
        public int cheese { get; set; } = 0;
        public int cabbage { get; set; } = 0;
        public int pepper { get; set; } = 0;
        public int bun { get; set; } = 2;

        public override string ToString()
        {
            return $"Burger: \ncotlets = {cotlet}\ntomatoes = {tomatoes}\ncucumbers = {cucumbers}\n" +
                $"cheese = {cheese}\ncabbage = {cabbage}\npepper = {pepper}\nbuns = {bun}";
        }
    }
    class Cheque
    {
        public string data { get; set; } = "";
        public override string ToString()
        {
            return data;
        }
    }
    class BurgerBuilder : IBuilder
    {
        private Burger instance = new Burger();
        public void Reset()
        {
            instance = new Burger();
        }
        public Burger GetResult()
        {
            Burger temp = instance;
            Reset();
            return temp;
        }
        public IBuilder AddCotlet()
        {
            instance.cotlet++;
            return this;
        }
        public IBuilder AddTomatoes()
        {
            instance.tomatoes++;
            return this;
        }
        public IBuilder AddCucumbers()
        {
            instance.cucumbers++;
            return this;
        }
        public IBuilder AddCheese()
        {
            instance.cheese++;
            return this;
        }
        public IBuilder AddCabbage()
        {
            instance.cabbage++;
            return this;
        }
        public IBuilder AddPepper()
        {
            instance.pepper++;
            return this;
        }
        public IBuilder AddBun()
        {
            instance.bun++;
            return this;
        }
    }
    class ChequeBuilder : IBuilder
    {
        private Cheque instance = new Cheque();
        public void Reset()
        {
            instance = new Cheque();
        }
        public Cheque GetResult()
        {
            Cheque temp = instance;
            Reset();
            return temp;
        }
        public IBuilder AddCotlet()
        {
            instance.data += "Добавлена котлета\n";
            return this;
        }
        public IBuilder AddTomatoes()
        {
            instance.data += "Добавлены помидоры\n";
            return this;
        }
        public IBuilder AddCucumbers()
        {
            instance.data += "Добавлена огурцы\n";
            return this;
        }
        public IBuilder AddCheese()
        {
            instance.data += "Добавлен сыр\n";
            return this;
        }
        public IBuilder AddCabbage()
        {
            instance.data += "Добавлена капуста\n";
            return this;
        }
        public IBuilder AddPepper()
        {
            instance.data += "Добавлен перец\n";
            return this;
        }
        public IBuilder AddBun()
        {
            instance.data += "Добавлена булочка\n";
            return this;
        }

    }
    class Director 
    {
        private IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void CreateCheapThing()
        {
            builder.AddCheese();
            builder.AddTomatoes();
        }
        public void CreateExpensiveThing()
        {
            builder.AddCheese();
            builder.AddCotlet();
            builder.AddBun();
            builder.AddCucumbers();
            builder.AddTomatoes();
            builder.AddPepper();
            builder.AddCabbage();
        }


    }
}
