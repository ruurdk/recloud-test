using Bogus;

public class AddressFaker : Faker<Address>
{
    PostalAddressFaker _pstlAdrFaker = new PostalAddressFaker();
    public AddressFaker() 
    {
        RuleFor(a => a.Nm, f => f.Name.FullName());
        RuleFor(a => a.PstlAdr, f => _pstlAdrFaker.Generate(1)
                                                .First()
                                                .OrNull(f, .1f)); // In 10% of cases, omit postal address.
    }
}