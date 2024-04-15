namespace HTTPRequest.Models
{
    public class FlowActionCaptureList : FlowActionCaptureVariable
    {
        /// <summary>
        /// List content.
        /// </summary>
        public FlowListContent VariableTypeList { get; set; }

        /// <summary>
        /// Optional. Message sent when no available option is selected by user. For example, when user types a ansewr instead selecte one.
        /// </summary>
        public string? MessageIfNoOptionSelected { get; set; }

        public FlowActionCaptureList(string variableName, FlowListContent variableTypeList, string? messageIfNoOptionSelected, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureType.Buttons, variableName, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
            this.VariableTypeList = variableTypeList;
            this.MessageIfNoOptionSelected = messageIfNoOptionSelected;
        }
    }
}
