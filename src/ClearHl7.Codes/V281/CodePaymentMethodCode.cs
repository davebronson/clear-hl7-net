namespace ClearHl7.Codes.V281
{
    /// <summary>
    /// HL7 Version 2 Table 0570 - Payment Method Code.
    /// </summary>
    /// <remarks>https://www.hl7.org/fhir/v2/0570</remarks>
    public enum CodePaymentMethodCode
    {
        /// <summary>
        /// CASH - Cash.
        /// </summary>
        Cash,

        /// <summary>
        /// CCCA - Credit Card.
        /// </summary>
        CreditCard,

        /// <summary>
        /// CCHK - Cashier's Check.
        /// </summary>
        CashiersCheck,

        /// <summary>
        /// CDAC - Credit/Debit Account.
        /// </summary>
        CreditDebitAccount,

        /// <summary>
        /// CHCK - Check.
        /// </summary>
        Check,

        /// <summary>
        /// DDPO - Direct Deposit.
        /// </summary>
        DirectDeposit,

        /// <summary>
        /// DEBC - Debit Card.
        /// </summary>
        DebitCard,

        /// <summary>
        /// SWFT - Society for Worldwide Interbank Financial Telecommunications (S.W.I.F.T.).
        /// </summary>
        SocietyForWorldwideInterbankFinancialTelecom,

        /// <summary>
        /// TRAC - Traveler's Check.
        /// </summary>
        TravelersCheck,

        /// <summary>
        /// VISN - VISA Special Electronic Funds Transfer Network.
        /// </summary>
        VisaSpecialElectronicFundsTransferNetwork
    }
}
