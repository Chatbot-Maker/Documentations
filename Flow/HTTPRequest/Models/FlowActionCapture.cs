namespace HTTPRequest.Models
{
    /// <summary>
    /// Flow action to capture data from user
    /// </summary>
    public abstract class FlowActionCapture : FlowAction
    {
        /// <summary>
        /// Property to be captured
        /// </summary>
        public FlowCaptureProperty Property { get; set; }

        /// <summary>
        /// Flag indicating whether property should always be captured, even if it has already been filled. Default = true
        /// </summary>
        public bool AlwaysCapture { get; set; } = true;

        /// <summary>
        /// Variable capture format (text, buttons or list options)
        /// </summary>
        public FlowCaptureType VariableType { get; set; }

        /// <summary>
        /// Optional. Message sent in case AlwaysCapture = false
        /// </summary>
        public string? MessageIfCaptured { get; set; }

        /// <summary>
        /// Optional. Message sent after data is captured
        /// </summary>
        public string? MessageAfterCaptured { get; set; }

        public FlowActionCapture(FlowCaptureProperty property, FlowCaptureType captureType, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowActionType.Capture, delay)
        {
            this.Property = property;
            this.AlwaysCapture = alwaysCapture;
            this.VariableType = captureType;
            this.MessageIfCaptured = messageIfCaptured;
            this.MessageAfterCaptured = messageAfterCaptured;
        }
    }
}
