namespace HTTPRequest.Models
{
    /// <summary>
    /// Request agent flow action. Transfer the user to a human attendant
    /// </summary>
    public class FlowActionRequestAgent : FlowAction
    {
        /// <summary>
        /// Optional. Department's ID to send the user
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// Optional. Agent's Id to send the user
        /// </summary>
        public string AgentId { get; set; }

        public FlowActionRequestAgent(string departmentId, string agentId, int delay = 0) : base(FlowActionType.RequestAgent, delay)
        {
            this.DepartmentId = departmentId;
            this.AgentId = agentId;
        }
    }
}
