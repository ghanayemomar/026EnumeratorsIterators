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
            //foreach (var i in ints)
            //{
            //    Console.WriteLine(i);
            //}
            //
            //
            //
            //
            //
            //
            //
            //

            var temps = new List<Tempreture>();
            Random rnd = new Random();
            for (var i = 0; i < 100; i++)
            {
                temps.Add(new Tempreture(rnd.Next(-30, 50)));
            }
            temps.Sort();
            foreach (var item in temps)
            {
                Console.WriteLine(item.Value);
            }
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
    //        _values = new[] { n1, n2, n3, n4, n5 };
    //    }

    //    public IEnumerable GetEnumerator()
    //    {
    //        foreach (var item in _values)
    //        {

    //            yield return item;
    //        }
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Tempreture : IComparable
    {
        private int _value { get; set; }
        public Tempreture(int value)
        {
            _value = value;
        }
        public int Value => _value;

        public int CompareTo(object obj)
        {
            if (obj is null) return 1;
            var temp = obj as Tempreture;
            if (temp is null) throw new ArgumentException("Oject is not a temp obj");
            return this._value.CompareTo(temp._value);
        }
    }

}