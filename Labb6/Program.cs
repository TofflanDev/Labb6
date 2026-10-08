using System.Collections;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employeeStack = new Stack<Employee>();
            Employee employee1 = new Employee(1, "Kalle", "Female", 100);
            Employee employee2 = new Employee(2, "Malte", "Male", 90);
            Employee employee3 = new Employee(3, "Larry", "male", 50);
            Employee employee4 = new Employee(4, "Garry", "Female", 1337);
            Employee employee5 = new Employee(5, "Terry", "Female", 32000);


            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);
            Console.WriteLine("prints all employees and their counts:");
            foreach (var item in employeeStack)
            {
                Console.WriteLine(item);
                Console.WriteLine(employeeStack.Count);
            }

            Console.WriteLine("------------");

            StackDelen(employeeStack);
           // IterateForLoop(employeeStack);

        }
        // STACK DELEN
        public static void StackDelen(Stack<Employee> eList)
        {
            //PART 1: Array pga for each knasar när stacken uppdateras med pop
            Employee[] copy = eList.ToArray();

            Console.WriteLine("\npop and print counts:\n");
            foreach (var item in copy)
            {
                Console.WriteLine(eList.Pop());
                Console.WriteLine(eList.Count);
            }
            //PART 2: Push again and print proof of correct order
            Console.WriteLine("\nPush again and print:\n");
            for (int i = copy.Length - 1; i >= 0; i--)
            {
                eList.Push(copy[i]);
            }

            foreach (var item in eList)
            {
                Console.WriteLine(item);
            }
            //PART 3: Peek and print counts
            Console.WriteLine("\nPeek:");

            Console.WriteLine(eList.Peek());
            Console.WriteLine(eList.Count);

            Console.WriteLine(eList.Peek());
            Console.WriteLine(eList.Count);
            //PART 4: Check if stack contains object number 3
            if (eList.Count >= 3)
            {
                Console.WriteLine("Objekt nummer 3 finns i stacken!");
            }
            else
            {
                Console.WriteLine("Objekt nummer 3 finns inte i stacken!");
            }

        }

        [Obsolete]
        public static void IterateForLoop(Stack<Employee> eList)
        {
            for (int i = eList.Count; i > 0; i--)
            {
                Console.WriteLine(eList.Pop());
                Console.WriteLine(eList.Count);

            }
        }

    }
}
