namespace knightmoves;
public class Party
{      
        public class Person {
                public string firstName { get; set; }
                public string lastname { get; set; }

                public Person (string firstName, string lastName) {
                        FirstName = firstName;
                        LastName = lastName;
                }
        }  
        
        public Person[] Guests = new Person[] {
                new Person("Dave", "Miller");
                new Person("Jack", "Kennedy");
                new person("Harry", "Fitzgerald");        
        };
}





