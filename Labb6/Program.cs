namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(new Employee(1,"Kalle","Female", 100));
            employeeStack.Push(new Employee(2,"Malte","Male", 90));
            employeeStack.Push(new Employee(3,"Larry", "male",50));
            employeeStack.Push(new Employee(4,"Garry","Female",1337));
            employeeStack.Push(new Employee(5,"Terry","Female",32000));

            //foreach (var item in employeeStack)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(employeeStack.Count);
            //}
            Console.WriteLine("------------");

            foreach (var item in employeeStack)
            {

                Console.WriteLine(employeeStack.Count);
                //Console.WriteLine(employeeStack.Pop());
                //Console.WriteLine(employeeStack.Count);

            }

        }
    }
}
