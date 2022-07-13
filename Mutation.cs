namespace gql_type_of_optional;

public class Mutation
{
    public Book CreateBook(CreateBookInput input)
    {
        Console.WriteLine(input);

        return new Book("a", new Author("b"));
    }
}
