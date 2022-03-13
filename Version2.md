# clear-hl7-net Version 2
Version 2 of clear-hl7-net is here.  Included in the changes are general enhancements, and modifications to some types to bring things into correct alignment with the HL7 spec.

HL7&reg; is the registered trademark of Health Level Seven International, and the use of this trademark does not constitute an endorsement by HL7.

## Types That Changed in Version 2
Some types in clear-hl7-net were changed to match the HL7 spec.

It's important to know that these are breaking from Version 1.x of this library.  Please be aware before updating to Version 2, and ready to adjust as needed.

### V230
|Component|Previous|New|
|---|---|---|
|`CtdSegment.ContactLocation`|`EntityIdentifier`|`PersonLocation`|
|`CtiSegment.SponsorStudyId`|`CodedElement`|`EntityIdentifier`|
|`Om1Segment.ObservationDescription`|`CodedElement`|`Text`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|
|`RxdSegment.DispenseNotes`|`IEnumerable<CodedElement>`|`IEnumerable<string>`|
|`CompositeIdWithCheckDigit.CheckDigit`|`decimal?`|`string`|
|`SpecimenSource` (corrected spelling)|`SpecimentSource`|`SpecimenSource`|

### V231
|Component|Previous|New|
|---|---|---|
|`ObxSegment.NatureOfAbnormalTest`|`string`|`IEnumerable<string>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|
|`CompositeIdWithCheckDigit.CheckDigit`|`decimal?`|`string`|
|`SpecimenSource` (corrected spelling)|`SpecimentSource`|`SpecimenSource`|

### V240
|Component|Previous|New|
|---|---|---|
|`AilSegment.LocationResourceId`|`IEnumerable<PersonLocation>`|`PersonLocation`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|
|`SpecimenSource` (corrected spelling)|`SpecimentSource`|`SpecimenSource`|

### V250
|Component|Previous|New|
|---|---|---|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|
|`SpecimenSource` (corrected spelling)|`SpecimentSource`|`SpecimenSource`|

### V251
|Component|Previous|New|
|---|---|---|
|`ObxSegment.ObservationValue`|`ChannelDefinition`|`IEnumerable<string>`|
|`ErqSegment.InputParameterList`|`QueryInputParameterList`|`IEnumerable<QueryInputParameterList>`|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`PidSegment.PatientAlias`|`ExtendedPersonName`|`IEnumerable<ExtendedPersonName>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|
|`Pv1Segment.DischargeDateTime`|`DateTime?`|`IEnumerable<DateTime>`|
|`SchSegment.AppointmentTimingQuantity`|`TimingQuantity`|`IEnumerable<TimingQuantity>`|
|`SpecimenSource` (corrected spelling)|`SpecimentSource`|`SpecimenSource`|

### V260
|Component|Previous|New|
|---|---|---|
|`ObxSegment.ObservationValue`|`ChannelDefinition`|`IEnumerable<string>`|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`PidSegment.PatientAlias`|`ExtendedPersonName`|`IEnumerable<ExtendedPersonName>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|
|`SchSegment.AppointmentTimingQuantity`|`TimingQuantity`|`IEnumerable<TimingQuantity>`|
|`SpecimenSource` (corrected spelling)|`SpecimentSource`|`SpecimenSource`|

### V270
|Component|Previous|New|
|---|---|---|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|

### V271
|Component|Previous|New|
|---|---|---|
|`ArqSegment.PlacerGroupNumber`|`EntityIdentifierPair`|`EntityIdentifier`|
|`EquSegment.EquipmentInstanceIdentifier`|`IEnumerable<EntityIdentifier>`|`EntityIdentifier`|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|

### V280
|Component|Previous|New|
|---|---|---|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|

### V281
|Component|Previous|New|
|---|---|---|
|`AdjSegment.AdjustmentSequenceNumber`|`EntityIdentifier`|`uint?`|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|

### V282
|Component|Previous|New|
|---|---|---|
|`AdjSegment.AdjustmentSequenceNumber`|`EntityIdentifier`|`uint?`|
|`IimSegment.InventoryOnHandQuantity`|`CodedWithExceptions`|`decimal?`|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|
|`ParentResultLink.ParentObservationSubIdentifier`|`ObservationGrouper`|`string`|

### V290
|Component|Previous|New|
|---|---|---|
|`Pd1Segment.PatientPrimaryCareProviderNameIdNo`|`ExtendedCompositeIdNumberAndNameForPersons`|`IEnumerable<ExtendedCompositeIdNumberAndNameForPersons>`|
|`Pr1Segment.ProcedurePriority`|`decimal?`|`string`|