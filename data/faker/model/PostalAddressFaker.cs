using Bogus;

public class PostalAddressFaker : Faker<PostalAddress>
{
    public PostalAddressFaker()
    {
        // Mandatory properties.        
        RuleFor(a => a.TwnNm, f => f.Address.City());
        RuleFor(a => a.Ctry, f => f.Address.CountryCode());

        // Expected properties.
        RuleFor(a => a.PstCd, f => f.Address.ZipCode());

        // Optional properties => Pick some.
        RuleFor(a => a.StrtNm, f => f.Address.StreetName());
        RuleFor(a => a.BldgNb, f => f.Address.BuildingNumber());    
        RuleFor(a => a.CtrySubDvsn, f => f.Address.State().OrNull(f, .3f)); // Skip State in 30% of cases.

        // Conditional => Skip.
    }
}