public class  Name
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string FullName => $"{this.FirstName} , {this.LastName}"; 
    public Name(string first, string last)
    {
        this.FirstName = first;
        this.LastName = last;
    }
    public override string ToString()
    {
        return $"{this.FirstName} , {this.LastName}";
    }
    
}