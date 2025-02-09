using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Demo
{
    //class StringComparer : IEqualityComparer<string>
    //{
    //    public bool Equals(string? x, string? y)
    //    {
    //       return x?.ToLower() == y?.ToLower();
    //    }

    //    public int GetHashCode([DisallowNull] string obj)
    //    {
    //        return obj.ToLower().GetHashCode(); 
    //    }
    //}


    //class Employee : IEquatable <Employee> { 
    //public int Id { get; set; }
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }

    //    public bool Equals(Employee? other)
    //    {
    //        return this.Id.Equals(other.Id) && this.Name.Equals(other.Name) && this.Salary.Equals(other.Salary);
    //    }

    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(Id,Name,sala);
    //    }
    //    public override string ToString() {
    //        return $"Id : {Id}, Name : {Name}, Salary : {Salary}";
    //    }
    
    }
    internal class Program
    {


        static void Main(string[] args)
        {


            #region HashTable Operation
            //Hashtable ht = new Hashtable() {

            //    //["Ahmed"]= 1,
            //};
            ////Add
            //ht.Add("Mostafa", 1);
            //ht.Add("Ahmed", 2);
            //ht.Add("Ayman", 3);


            ////Safe Add
            //if (!ht.ContainsKey("Ahmed")) {
            //    ht.Add("Ahmed", 2);
            //}
            //// Get
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($"Key: {item.Key} ,value: {item.Value} ");
            //}
            //foreach (var key in ht.Keys)
            //{
            //    Console.WriteLine($"Key: {key} ");

            //}
            //foreach (var value in ht.Values)
            //{
            //    Console.WriteLine($"value: {value} ");
            //} 
            #endregion


            #region Dictionary

            //Dictionary<string,int> note = new Dictionary<string,int>();
            //Dictionary<string,int> note02 = new Dictionary<string,int>(note,new StringComparer());

            ////Add
            //note.Add("Ahmed", 111);
            //note.Add("Ayman", 222);
            //note.Add("Eman", 333);
            //note.Add("Ahmed", 111);

            ////Safe Add
            //if (!note.ContainsKey("Ahmed"))
            //{
            //    note.Add("Ahmed", 2);
            //}
            //// Get
            //foreach (var item in note)
            //{
            //    Console.WriteLine($"Name = {item.Key} ::: Number= {item.Value}");
            //}



            //Employee employee01 = new Employee() { Id=10,Name= "Ahmed",Salary=5_000};
            //Employee employee02 = new Employee() { Id=20,Name= "Eman",Salary=6_000};
            //Employee employee03 = new Employee() { Id=30,Name= "Ayman",Salary=7_000};

            //Dictionary<Employee,string> employees = new Dictionary<Employee, string>() {

            //    [employee01]= employee01.ToString(),
            //    [employee02]= employee02.ToString(),
            //    [employee03]= employee03.ToString(),
            //};
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"Name = {employee.Key} ::: Number= {employee.Value}");
            //}

            //employees.Add(new Employee() { Id = 10, Name = "Ahmed", Salary = 5_000 },null);
            #endregion

        }
    }
}
