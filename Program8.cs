using System;

namespace MyConsoleApplication
{
    public class Program8
    {
        public static void Main(string[] args)
        {
            CustomStack st = new CustomStack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU (size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        st.Push(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Top element is: {0}", st.Peek());
                        break;
                    case 3:
                        Console.WriteLine("Element removed: {0}", st.Pop());
                        break;
                    case 4:
                        st.Display();
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }

    public interface IStackADT
    {
        bool IsEmpty();
        void Push(object element);
        object Pop();
        object Peek();
        void Display();
    }

    public class CustomStack : IStackADT
    {
        private int StackSize;
        public int StackSizeSet
        {
            get { return StackSize; }
            set { StackSize = value; }
        }
        public int top;
        public object[] item;

        public CustomStack()
        {
            StackSizeSet = 10;
            item = new object[StackSizeSet];
            top = -1;
        }

        public CustomStack(int capacity)
        {
            StackSizeSet = capacity;
            item = new object[StackSizeSet];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top--];
            }
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
            }
        }

        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }
    }
}
