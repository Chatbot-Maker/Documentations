namespace HTTPRequest.Models
{
    public class FlowActionCaptureEmail : FlowActionCapture
    {
        /// <summary>
        /// Message that will request the data. For example, "Whats's your email?"
        /// </summary>
        public string MessageQuestion { get; set; }

        public FlowActionCaptureEmail(string messageQuestion, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureProperty.Email, FlowCaptureType.Text, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
            this.MessageQuestion = messageQuestion;
        }
    }
}
