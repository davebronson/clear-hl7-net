﻿namespace ClearHl7.Codes.V230
{
    /// <summary>
    /// HL7 Version 2 Table 0202 - Telecommunication Equipment Type.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0202</remarks>
    public enum CodeTelecommunicationEquipmentType
    {
        /// <summary>
        /// BP - Beeper.
        /// </summary>
        Beeper,
        
        /// <summary>
        /// CP - Cellular or Mobile Phone.
        /// </summary>
        CellularOrMobilePhone,
        
        /// <summary>
        /// FX - Fax.
        /// </summary>
        Fax,
        
        /// <summary>
        /// Internet - Internet Address.
        /// </summary>
        InternetAddress,
        
        /// <summary>
        /// MD - Modem.
        /// </summary>
        Modem,
        
        /// <summary>
        /// PH - Telephone.
        /// </summary>
        Telephone,
        
        /// <summary>
        /// X.400 - X.400 email address.
        /// </summary>
        X400EmailAddress
    }
}