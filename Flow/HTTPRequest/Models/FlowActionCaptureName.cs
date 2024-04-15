namespace HTTPRequest.Models
{
    public class FlowActionCaptureName : FlowActionCapture
    {
        /// <summary>
        /// Message that will request the data. For example, "Whats's your name?"
        /// </summary>
        public string MessageQuestion { get; set; }

        public FlowActionCaptureName(string messageQuestion, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureProperty.Name, FlowCaptureType.Text, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
            this.MessageQuestion = messageQuestion;
        }
    }
}
