namespace knightmoves;

public class Party
{      
    public Person[] Guests = new Person[] 
    {
        new Person("Dave", "Miller"),
        new Person("Jack", "Kennedy"),
        new Person("Harry", "Fitzgerald")        
    };
}

public class Person 
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
        
    public Person (string firstName, string lastName) 
        {
                FirstName = firstName;
                LastName = lastName;
        }
}  









