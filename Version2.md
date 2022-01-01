# clear-hl7-net Version 2
Version 2 of clear-hl7-net is under development.  Included in the changes are general enhancements, and changes to some types to bring things into correct alignment with the HL7 spec.

HL7® is the registered trademark of Health Level Seven International, and the use of this trademark does not constitute an endorsement by HL7.

## Types That Are Changing in Version 2
Some types in clear-hl7-net are being corrected to match the HL7 spec.  These are simple changes from one type to another.

It's important to know that they are breaking from Version 1.x of this library.  Please be aware of these before updating to Version 2, and ready to adjust your code if you use one of the types below.
|Version|Component|Previous|New|
|---|---|---|---|
|V271|`ArqSegment.PlacerGroupNumber`|`EntityIdentifierPair`|`EntityIdentifier`|
|V271|`EquSegment.EquipmentInstanceIdentifier`|`IEnumerable<EntityIdentifier>`|`EntityIdentifier`|