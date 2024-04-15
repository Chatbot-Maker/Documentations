namespace HTTPRequest.Models
{
    public class FlowActionCaptureText : FlowActionCaptureVariable
    {
        /// <summary>
        /// Message that will request the data.
        /// </summary>
        public string MessageQuestion { get; set; }

        public FlowActionCaptureText(string messageQuestion, string variableName, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureType.Text, variableName, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
        }
    }
}
