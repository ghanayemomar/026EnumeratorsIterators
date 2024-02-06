using System.Collections;

namespace _026EnumeratorsIterators
{

    class Program
    {
        static void Main(String[] args)
        {
            Employee e1 = new Employee { Id = 100, Name = "Omar Ghanayem", Salary = 1000m, Department = "IT" };
            Employee e2 = new Employee { Id = 100, Name = "Omar Ghanayem", Salary = 1000m, Department = "IT" };
            //
            Console.WriteLine(e1.Equals(e2));
            Console.WriteLine(e1 == e2); // false comparing the references.
            Employee e3 = e1;
            Console.WriteLine(e1 == e3);
            //
            var s2 = "Hello";
            var s1 = "Hello";
            Console.WriteLine(s1 == s2); //only in string it compare the contants 
            //
            Console.WriteLine(s1 == s2);
            //
            //
            //
            //
            //var ints = new FiveIntegers(1, 2, 3, 4, 5);
            //foreach(var i in ints)
            //{
            //    Console.WriteLine(i);   
            //}


            Console.ReadKey();
        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee)) return false;

            var emp = obj as Employee;

            return this.Id == emp.Id
                && this.Name == emp.Name
                && this.Salary == emp.Salary
                && this.Department == emp.Department;

        }

        public override int GetHashCode()
        {
            int hash = 13; //should use primary number.
            hash = (hash * 7) + Id.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Salary.GetHashCode();
            hash = (hash * 7) + Department.GetHashCode();
            return base.GetHashCode();

        }
        public static bool operator ==(Employee lhs, Employee rhs) => lhs.Equals(rhs);
        public static bool operator !=(Employee lhs, Employee rhs) => !lhs.Equals(rhs);
    }
    //class FiveIntegers : IEnumerable
    //{
    //    int[] _values;

    //    public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
    //    {
    //        _values = new[] {n1,n2,n3,n4,n5};  
    //    }

    //    public IEnumerable GetEnumerator() => new Enumerator(this);

    //    class Enumerator : IEnumerator
    //    {
    //        int currentIndex = -1;
    //        FiveIntegers _itegers;
    //        public Enumerator(FiveIntegers itegers) 
    //        { 
    //            _itegers = itegers;
    //        }

    //        public object Current => throw new NotImplementedException();

    //        public bool MoveNext()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public void Reset()
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    }
//}