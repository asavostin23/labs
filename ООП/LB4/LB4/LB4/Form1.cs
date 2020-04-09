using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public abstract class State
    {
        protected Calculator calc;
        
        public void SetCalc(Calculator calc) => this.calc = calc;

        public abstract void PrintDigit(int num);
        public abstract void Operation(Calculator.OperationEnum operation);
        public abstract void Equal();
    }
    public class StateZero : State
    {
        public StateZero(Calculator calc) => SetCalc(calc);
        public override void PrintDigit(int num)
        {
            //calc.tempNum = 0;
            calc.PrintNumber(num);
            calc.SetState(new StateOne(calc));
        }
        public override void Operation(Calculator.OperationEnum operation)
        {
            //throw new Exception("Состояние 0: Operation() невозможен");
            calc.operation = operation;
            calc.SetState(new StateTwo(calc));

        }
        public override void Equal()
        {
            //throw new Exception("Состояние 0: Equal() невозможен");
        }
    }
    public class StateOne : State
    {
        public StateOne(Calculator calc) => SetCalc(calc);
        public override void PrintDigit(int num)
        {
            calc.PrintNumber(calc.GetNumber() * 10 + num);
        }
        public override void Operation(Calculator.OperationEnum operation)
        {
            calc.operation = operation;
            calc.SetState(new StateTwo(calc));
        }
        public override void Equal()
        {
            //throw new Exception("Состояние 1: Equal() невозможен");
        }
    }
    public class StateTwo : State
    {
        public StateTwo(Calculator calc) => SetCalc(calc);
        public override void PrintDigit(int num)
        {
            calc.tempNum = calc.GetNumber();
            calc.PrintNumber(num);
            calc.SetState(new StateThree(calc));
        }
        public override void Operation(Calculator.OperationEnum operation)
        {
            //throw new Exception("Состояние 2: Operation() невозможен");
        }
        public override void Equal()
        {
            //throw new Exception("Состояние 2: Equal() невозможен");
        }
    }
    public class StateThree : State
    {
        public StateThree(Calculator calc) => SetCalc(calc);
        public override void PrintDigit(int num)
        {
            calc.PrintNumber(calc.GetNumber() * 10 + num);
        }
        public override void Operation(Calculator.OperationEnum operation)
        {
            switch(calc.operation)
            {
                case Calculator.OperationEnum.plus:
                    calc.PrintNumber(calc.tempNum + calc.GetNumber());
                    break;
                case Calculator.OperationEnum.minus:
                    calc.PrintNumber(calc.tempNum - calc.GetNumber());
                    break;
                case Calculator.OperationEnum.divide:
                    if (calc.GetNumber() == 0)
                        calc.PrintError();
                    else
                        calc.PrintNumber(calc.tempNum / calc.GetNumber());
                    break;
                case Calculator.OperationEnum.multiply:
                    calc.PrintNumber(calc.tempNum * calc.GetNumber());
                    break;
                case Calculator.OperationEnum.mod:
                    calc.PrintNumber(calc.tempNum % calc.GetNumber());
                    break;
            }
            calc.operation = operation;
            calc.SetState(new StateTwo(calc));
        }
        public override void Equal()
        {
            switch (calc.operation)
            {
                case Calculator.OperationEnum.plus:
                    calc.PrintNumber(calc.tempNum + calc.GetNumber());
                    break;
                case Calculator.OperationEnum.minus:
                    calc.PrintNumber(calc.tempNum - calc.GetNumber());
                    break;
                case Calculator.OperationEnum.divide:
                    if (calc.GetNumber() == 0)
                        calc.PrintError();
                    else
                        calc.PrintNumber(calc.tempNum / calc.GetNumber());
                    
                    break;
                case Calculator.OperationEnum.multiply:
                    calc.PrintNumber(calc.tempNum * calc.GetNumber());
                    break;
                case Calculator.OperationEnum.mod:
                    calc.PrintNumber(calc.tempNum % calc.GetNumber());
                    break;
            }
            calc.SetState(new StateZero(calc));
        }
    }
    public class Calculator
    {   
        public Calculator(Form1 form)
        {
            this.form = form;
            this.form.Text = "LB1";
            Clear();
            //PrintNumber(0);
        }

        private int memory = 0;
        public int GetMemory() => memory;
        public int SetMemory(int num) => memory = num;

        private State state;// = new StateZero();
        public void SetState(State state) => this.state = state;

        public void PrintDigit(int num) => state.PrintDigit(num);
        public void Operation(OperationEnum operation) => state.Operation(operation);
        public void Equal() => state.Equal();

        public enum OperationEnum { plus, minus, multiply, divide, mod }
        public OperationEnum operation;
        private Form1 form;

        public int tempNum = 0;
        public void PrintNumber(int num) => form.SetTextBox(num);
        public int GetNumber() => form.GetTextBox();
        public void PrintError() => form.SetTextBox("Error!");

        //public void PrintDigit(int digit) 
        //{
        //    if (state == StateEnum.firstNum)
        //        PrintNumber(form.GetTextBox() * 10 + digit);
        //    else
        //    {
        //        tempNum
        //        //switch (operation)
        //        //{
        //        //    case OperationEnum.plus:
        //        //        tempNum += form.GetTextBox();
        //        //        break;
        //        //    case OperationEnum.minus:
        //        //        tempNum -= form.GetTextBox();
        //        //        break;
        //        //    case OperationEnum.multiply:
        //        //        tempNum *= form.GetTextBox();
        //        //        break;
        //        //    case OperationEnum.divide:
        //        //        tempNum /= form.GetTextBox();
        //        //        break;
        //        //    case OperationEnum.mod:
        //        //        tempNum %= form.GetTextBox();
        //        //        break;
        //        //}
        //        //tempNum = form.GetTextBox();
        //    }
            
        //}
        public void Clear()
        { 
            PrintNumber(0);
            tempNum = 0;//
            state = new StateZero(this);
        }
        
    }

    public partial class Form1 : Form
    {
        public void SetTextBox(int num) => textBox1.Text = num.ToString();
        public void SetTextBox(string str) => textBox1.Text = str;
        public int GetTextBox()
        {
            try
            {
                return int.Parse(this.textBox1.Text);
            }
            catch
            {
                return 0;
            }
        }
        protected Calculator calculator;
        public void SetCalculator(Calculator calculator) => this.calculator = calculator;
        

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Calculator calculator) : base()
        {
            this.calculator = calculator;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(9);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            calculator.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calculator.PrintDigit(0);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            calculator.Operation(Calculator.OperationEnum.mod);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculator.SetMemory(calculator.GetMemory() + calculator.GetNumber());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calculator.PrintNumber(calculator.GetMemory());
            calculator.SetMemory(0);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            calculator.Operation(Calculator.OperationEnum.divide);
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            calculator.Operation(Calculator.OperationEnum.multiply);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculator.Operation(Calculator.OperationEnum.minus);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button16_Click(object sender, EventArgs e)
        {
            calculator.Operation(Calculator.OperationEnum.plus);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            calculator.Equal();
        }
    }
}
