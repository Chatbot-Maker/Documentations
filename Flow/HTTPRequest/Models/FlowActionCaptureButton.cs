namespace HTTPRequest.Models
{
    public class FlowActionCaptureButton : FlowActionCaptureVariable
    {
        /// <summary>
        /// 
        /// </summary>
        public FlowButtonContent VariableTypeButtons { get; set; }

        /// <summary>
        /// Optional. Message sent when no available option is selected by user. For example, when user types a ansewr instead selecte one.
        /// </summary>
        public string? MessageIfNoOptionSelected { get; set; }

        public FlowActionCaptureButton(string variableName, FlowButtonContent variableTypeButtons, string? messageIfNoOptionSelected, bool alwaysCapture = true, string? messageIfCaptured = null, string? messageAfterCaptured = null, int delay = 0) : base(FlowCaptureType.Buttons, variableName, alwaysCapture, messageIfCaptured, messageAfterCaptured, delay)
        {
            this.VariableTypeButtons = variableTypeButtons;
            this.MessageIfNoOptionSelected = messageIfNoOptionSelected;
        }
    }
}
