# ISO 20022 address format

### Specification

Postal Address <PstlAdr>
| Description | Tag | Width |
| ----------- | ------- | ------ |
| Address Type | <AdrTp> | (4 characters) | 
| Department | <Dept> | (up to 70 characters) | 
| Sub Department | <SubDept> | (up to 70 characters) | 
| Street Name | <StrtNm> | (up to 70 characters) |
| Building Number | <BldgNb> | (up to 16 characters) | 
| Building Name | <BldgNm> | (up to 35 characters) |
| Floor | <Flr> | (up to 70 characters) |
| Post Box | <PstBx> | (up to 16 characters) |
| Room | <Room> | (up to 70 characters) |
| Post Code | <PstCd> | (up to 16 characters) |
| Town Name | <TwnNm> | (up to 35 characters) |
| Town Location Name | <TwnLctnNm> | (up to 35 characters) |
| District Name | <DstrctNm> | (up to 35 characters) |
| Country Sub Division | <CtrySubDvsn> | (up to 35 characters) |
| Country | <Ctry> | (2 characters) |
| Address Line | <AdrLine> | (up to 70 characters, repetitive) |


### XML example

```xml
<PstlAdr>
    <Dept>Procurement Services</Dept>
    <StrtNm>South LaSalle Street</StrtNm>
    <BldgNb>120</BldgNb>
    <PstCd>60690-0834</PstCd>
    <TwnNm>Chicago</TwnNm>
    <CtrySubDvsn>IL</CtrySubDvsn>
    <Ctry>US</Ctry>s
</PstlAdr>
``````