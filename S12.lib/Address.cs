public class Address
{
    public string State {get; set;}
    public string Town {get; set;}
    public string Street {get; set;}
    public string Fulladdress => $"{this.State} , {this.Town} , {this.Street}"; 
    public Address(string state, string town, string street)
    {
        this.State = state;
        this.Town = town;
        this.Street = street;
    }
    public override string ToString()
    {
        return $"{this.State} , {this.Town} , {this.Street}"; 
    }

}