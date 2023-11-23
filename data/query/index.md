

### Create an index on JSON keys prefixed with "address:"

Ideally create this index before you load data.

```
FT.CREATE idx:address_json                 // Index name
  ON JSON                                  // Indicates the type of data to index
    PREFIX 1 "address:"                    // Tells the index which keys it should index
  SCHEMA
    $.Nm AS name TEXT NOSTEM SORTABLE      // Will be indexed as a sortable TEXT field. Stemming is disabled - which is ideal for proper names.
    $.PstlAdr.StrtNm AS street TEXT NOSTEM // '$.PstlAdr.StrtNm' field will be indexed as TEXT and can be referred as 'street' due to the '... AS fieldname ...' construct.
    $.PstlAdr.TwnNm AS town TEXT NOSTEM
    $.PstlAdr.Ctry AS country TAG
    $.PstlAdr.PstCd AS postalcode TEXT NOSTEM
```

### Info on index

`FT.INFO idx:address_json`

### Search

`FT.SEARCH idx:address_json "Henry""`

### Search returning only select fields

`FT.SEARCH idx:address_json "Henry" RETURN 2 name street`