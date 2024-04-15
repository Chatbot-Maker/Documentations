namespace HTTPRequest.Models
{
    /// <summary>
    /// Flow capture type
    /// </summary>
    public enum FlowCaptureType
    {
        /// <summary>
        /// User can type any text and it's accepted and storage in variable
        /// </summary>
        Text = 0,

        /// <summary>
        /// User can choose between until 3 button options. The button's title is the value to be captured
        /// </summary>
        Buttons = 1,

        /// <summary>
        /// User can choose between until 10 list options. The list option's title is the value to be captured
        /// </summary>
        List = 2
    }
}
