namespace HTTPRequest.Models
{
    public class FlowActionCaptureDocument : FlowActionCapture
    {
        /// <summary>
        /// Message that will request the data. For example, "Whats's your identification document?"
        /// </summary>
        public string MessageQuestion { get; set; }

        public FlowActionCaptureDocument(string messageQuestion, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureProperty.IdentificationDocument, FlowCaptureType.Text, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
            this.MessageQuestion = messageQuestion;
        }
    }
}
