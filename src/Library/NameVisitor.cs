namespace Library;

public class NameVisitor : IVisitor<Person>
{
    private string longest;
    public NameVisitor()
    {
        this.longest = "";
    }
    
    public void Visit(Node<Person> node)
    {
        Person ActualPerson = node.Value;
        if (ActualPerson.Name.Length > longest.Length)
        {
            longest = node.Value.Name;
        }
    }
}