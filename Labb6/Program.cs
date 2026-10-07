using System.Collections;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Kalle", "Female", 100);
            Employee employee2 = new Employee(2, "Malte", "Male", 90);
            Employee employee3 = new Employee(3, "Larry", "male", 50);
            Employee employee4 = new Employee(4, "Garry", "Female", 1337);
            Employee employee5 = new Employee(5, "Terry", "Female", 32000);

            Stack<Employee> employeeStack = new Stack<Employee>();

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (var item in employeeStack)
            {
                Console.WriteLine(item);
                Console.WriteLine(employeeStack.Count);
            }

            Console.WriteLine("------------");

            // IterateForLoop(employeeStack);

            IterateArrayCopy(employeeStack);
        }

        public static void IterateArrayCopy(Stack<Employee> eList)
        {
            Employee[] copy = eList.ToArray();
            //Array pga for each knasar när stacken uppdateras med pop
            foreach (var item in copy)
            {
                Console.WriteLine(eList.Pop());
                Console.WriteLine(eList.Count);
            }

            Console.WriteLine("\nPush again");
            
            for (int i = copy.Length - 1; i >= 0; i--)
            {
                eList.Push(copy[i]);
            }

            foreach (var item in eList)
            {
                Console.WriteLine(item);
            }

        }
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
