public class  Person
{
    public Name Person_Name{get;set;}
    public string Person_Number{get;set;}
    public string? Person_Email{get;set;}
    public Address Person_Address{get;set;}

    public Person(Name Person_Name, string Person_Number, string? Person_Email,Address Person_Address)
    {
        this.Person_Name = Person_Name;
        this.Person_Number = Person_Number;
        this.Person_Email = Person_Email;
        this.Person_Address = Person_Address;
    }
    public override string ToString()
    {
        return $"{this.Person_Name} ,{this.Person_Number} ,{this.Person_Email} ,{this.Person_Address}";
    }
    public static Person new_person(string p)
    {
        var toks = p.Split(",");
        Name newname = new Name(toks[0], toks[1]);
        Address newaddress = new Address(toks[4], toks[5], toks[6]);
        Person newP = new Person(newname,toks[2],toks[3],newaddress);
        return newP;
    }

}