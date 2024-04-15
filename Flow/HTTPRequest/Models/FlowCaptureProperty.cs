namespace HTTPRequest.Models
{
    /// <summary>
    /// The user property to be captured
    /// </summary>
    public enum FlowCaptureProperty
    {
        /// <summary>
        /// To capture the user name
        /// </summary>
        Name = 0,

        /// <summary>
        /// To capture the user email
        /// </summary>
        Email = 1,

        /// <summary>
        /// To capture the user phone
        /// </summary>
        Phone = 2,

        /// <summary>
        /// To capture the user identification document (like CPF or driver license)
        /// </summary>
        IdentificationDocument = 3,

        /// <summary>
        /// To capture a custom variable
        /// </summary>
        Variable = 100
    }
}
