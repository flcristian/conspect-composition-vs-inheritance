


// INHERITANCE

public class Person
{
    private int _id;
    private int _age;
    private string _name;
    private string _email;

    // Constructors

    public Person(int id, int age, string name, string email)
    {
        _id = id;
        _age = age;
        _name = name;
        _email = email;
    }

    // Accessors

    public int Id
    {
        get { return _id; }
        set
        {
            _id = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            _age = value;
        }
    }

    public string Name
    {
        get { return _name; }
        set 
        { 
            _name = value;
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            _email = value;
        }
    }
}

public class Customer : Person
{
    public string _adress;

    // Constructors
    
    public Customer(int id, int age, string name, string email, string adress) : base(id, age, name, email)
    {
        _adress = adress;
    } 

    // Accessors

    public string Adress
    {
        get { return _adress; }
        set
        {
            _adress = value;
        }
    }
}

public class Supplier : Person
{
    public string _phone;

    // Constructors

    public Supplier(int id, int age, string name, string email, string phone) : base(id, age, name, email)
    {
        _phone = phone;
    }

    // Accessors

    public string Phone
    {
        get { return _phone; }
        set
        {
            _phone = value;
        }
    }
}

// COMPOSITION

public class Book
{
    private int _id;
    private string _title;

    // Constructors

    public Book(int id, string title)
    {
        _id = id;
        _title = title;
    }

    // Accessors

    public int Id
    {
        get { return _id; }
        set
        {
            _id = value;
        }
    }

    public string Title
    {
        get { return _title; }
        set
        {
            _title = value;
        }
    }
}

public class Author
{
    protected List<Book> books = new List<Book>();
}

// PROGRAM

internal class Program
{ 
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}