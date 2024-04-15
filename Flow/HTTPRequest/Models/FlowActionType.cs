namespace HTTPRequest.Models
{
    /// <summary>
    /// Floe action type
    /// </summary>
    public enum FlowActionType
    {
        /// <summary>
        /// Send text
        /// </summary>
        Text = 0,

        /// <summary>
        /// Send media (image, video, document or audio)
        /// </summary>
        Media = 1,

        /// <summary>
        /// Send location
        /// </summary>
        Location = 2,

        /// <summary>
        /// Send to other flow
        /// </summary>
        GoToFlow = 3,

        /// <summary>
        /// Transfer to human attendant
        /// </summary>
        RequestAgent = 4,

        /// <summary>
        /// Capture user data (like name, email or variable)
        /// </summary>
        Capture = 7
    }
}
