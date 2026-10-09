using System.Collections;

namespace Labb6
{
    internal class Program
    {
        //STYRKA: LAMBDA UTTRYCK!!

        //SVAGHET: SPAGHETTI KOD I MAIN. ANVÄNDER FOR EACH FÖR POP DELEN VILKET ÄR DÅLIGT EFTERSOM MÅSTE SKAPA ARRAY COPY SÅ DET INTE KRASHAR.

        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Kalle", "Female", 100);
            Employee employee2 = new Employee(2, "Malte", "Male", 90);
            Employee employee3 = new Employee(3, "Larry", "male", 50);
            Employee employee4 = new Employee(4, "Garry", "Female", 1337);
            Employee employee5 = new Employee(5, "Terry", "Female", 32000);

            //DEL 1 ///////////////////////////////////////////////////////////////////

            Stack<Employee> employeeStack = new Stack<Employee>();
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

            // DEL 2 /////////////////////////////////////////////////////////////////////
            List<Employee> employeesList = new List<Employee>();

            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);
            Console.WriteLine("------------");
            //PART 1 CREATE A CONDITION TO FIND EMPLOYEE 2
            if (employeesList.Contains(employee2))
            {
                Console.WriteLine("\nEmployee 2 finns i listan!");
            }
            else
            {
                Console.WriteLine("\nEmployee 2 finns inte i listan!");
            }
            //PART 2 FIND THE FIRST MALE
            Employee employeeReference = employeesList.Find(e => e.Gender == "Male");
            Console.WriteLine("\n");
            Console.WriteLine(employeeReference);


            //PART 3 FIND ALL MALES
            Console.WriteLine("\n");
            foreach (var item in employeesList.FindAll(e => 
            String.Equals(e.Gender, "Male", StringComparison.OrdinalIgnoreCase))) //EQUALS compares string e.Gender and "Male" and if true returns true otherwise false
                                                                                  //Also applying the rule "OrdinalIgnoreCase", 
            {
                Console.WriteLine(item);
            }

        }


        // STACK DELEN
        public static void StackDelen(Stack<Employee> eList)
        {
            //PART 1: Array copy - otherwise would crash because of dynamic container changing size while poping
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
        //JAG BÖRJADE MED FOR LOOP MEN VET INTE OM MAN ÄR TVUNGEN ATT ANVÄNDA FOR EACH FÖR DET MEN STÅR IAF I UPPGIFTEN ATT ANVÄND FOR EACH SÅ GJORDE DET.
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
