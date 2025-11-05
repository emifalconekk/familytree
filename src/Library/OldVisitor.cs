namespace Library;

public class OldVisitor : IVisitor<Person>
{

    private int oldest;
    
    public OldVisitor ()
    {
        this.oldest = 0;
    }

    public void Visit(Node<Person> node)
    {
        Person ActualPerson = node.Value;
        if (ActualPerson.Age > oldest)
        {
            oldest = node.Value.Age;
        }
    }
}
