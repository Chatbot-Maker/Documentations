namespace HTTPRequest.Models
{
    public abstract class FlowActionCaptureVariable : FlowActionCapture
    {
        /// <summary>
        /// Name that identifies the data captured from user.
        /// </summary>
        public string VariableName { get; set; }

        public FlowActionCaptureVariable(FlowCaptureType captureType, string variableName, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureProperty.Variable, captureType, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
        }
    }
}
