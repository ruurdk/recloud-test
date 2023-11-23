# ISO 20022 address format

### Specification

Addresses have a mandatory name ```<Nm>``` (by which a party is known and postal address ```<PstlAdr>```

| Field | Tag | Description | Usage |
| ----------- | -----| ----------- | ------ |
| Department | ```<Dept>``` | Identification of a division of a large organisation or building. |  conditional | 
| Sub Department | ```<SubDept>``` | Identification of a sub-division of a large organisation or building. | conditional | 
| Street Name | ```<StrtNm>``` | Name of a street or thoroughfare. | optional |
| Building Number | ```<BldgNb>``` | Number that identifies the position of a building on a street. | optional | 
| Building Name | ```<BldgNm>``` | Name of the building or house. | optional |
| Floor | ```<Flr>``` | Floor or storey within a building. | conditional |
| Post Box | ```<PstBx>``` | Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for. | optional |
| Room | ```<Room>``` | Room | optional |
| Post Code | ```<PstCd>``` | Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail. | expected |
| Town Name | ```<TwnNm>``` | Name of a built-up area, with defined boundaries, and a local government. | mandatory |
| Town Location Name | ```<TwnLctnNm>``` | Specific location name within the town. | optional |
| District Name | ```<DstrctNm>``` | Identifies a subdivision within a country sub-division. | optional |
| Country Sub Division | ```<CtrySubDvsn>``` | Identifies a subdivision of a country such as state, region, county. | optional |
| Country | ```<Ctry>``` | Nation with its own government. | mandatory |


### XML example

```xml
<PstlAdr>
    <Dept>Procurement Services</Dept>
    <StrtNm>South LaSalle Street</StrtNm>
    <BldgNb>120</BldgNb>
    <PstCd>60690-0834</PstCd>
    <TwnNm>Chicago</TwnNm>
    <CtrySubDvsn>IL</CtrySubDvsn>
    <Ctry>US</Ctry>
</PstlAdr>
```

### JSON example

We keep to the XML tags as field names in JSON. An address would then be:

```json
{
    "Nm": "Joe Black",
    "PstAdr": {
        "Dept": "Procurement Services",
        "StrtNm": "South LaSalle Street",
        "BldgNb": 120,
        "PstCd": "60690-0834",
        "TwnNm": "Chicago",
        "CtrySubDvsn": "IL",
        "Ctry": "US"
    }
}
```