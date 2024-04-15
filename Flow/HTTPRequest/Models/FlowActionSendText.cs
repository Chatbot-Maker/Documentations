namespace HTTPRequest.Models
{
    /// <summary>
    /// Text flow action. Sends a text message to user
    /// </summary>
    public class FlowActionSendText : FlowAction
    {
        /// <summary>
        /// Text to send
        /// </summary>
        public string Text { get; set; }

        public FlowActionSendText(string text, int delay = 0) : base(FlowActionType.Text, delay)
        {
            this.Text = text;
        }
    }
}
