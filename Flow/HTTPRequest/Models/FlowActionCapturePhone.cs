namespace HTTPRequest.Models
{
    public class FlowActionCaptureCapture : FlowActionCapture
    {
        /// <summary>
        /// Message that will request the data. For example, "Whats's your phone number?"
        /// </summary>
        public string MessageQuestion { get; set; }

        public FlowActionCaptureCapture(string messageQuestion, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureProperty.Phone, FlowCaptureType.Text, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
            this.MessageQuestion = messageQuestion;
        }
    }
}
