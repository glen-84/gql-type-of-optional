namespace gql_type_of_optional;

public class CreateBookInput
{
    [DefaultValue("")]
    [GraphQLType(typeof(EmailAddressType))]
    public Optional<string> EmailAddress { get; init; }
}
