namespace HTTPRequest.Models
{
    /// <summary>
    /// Redirect to flow action. Redirects the user to another flow using the ID
    /// </summary>
    public class FlowActionGoToFlow : FlowAction
    {
        /// <summary>
        /// Flow ID to redirect the user
        /// </summary>
        public string FlowId { get; set; }

        public FlowActionGoToFlow(string flowId, int delay = 0) : base(FlowActionType.GoToFlow, delay)
        {
            this.FlowId = flowId;
        }
    }
}
