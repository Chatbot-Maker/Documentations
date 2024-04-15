namespace HTTPRequest.Models
{
    /// <summary>
    /// Base class of Flow Action
    /// </summary>
    public abstract class FlowAction
    {
        /// <summary>
        /// Flow action type
        /// </summary>
        public FlowActionType Type { get; set; }

        /// <summary>
        /// Delay to send action (in seconds)
        /// </summary>
        public int Delay { get; set; }

        public FlowAction(FlowActionType type, int delay = 0)
        {
            Type = type;
            Delay = delay;
        }
    }
}
