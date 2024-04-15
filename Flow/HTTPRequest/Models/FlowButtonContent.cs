namespace HTTPRequest.Models
{
    /// <summary>
    /// Content of a button message
    /// </summary>
    public class FlowButtonContent
    {
        /// <summary>
        /// Content type of data displayed in message
        /// </summary>
        public FlowButtonContentType ContentType { get; set; }

        /// <summary>
        /// Optional. Header displayed above Text when ContentType = Text
        /// </summary>
        public string? Header { get; set; }

        /// <summary>
        /// The main text of message. It's usually a question whose answer options are the buttons
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Optional. Caption displayed below Text when ContentType = Text
        /// </summary>
        public string? Caption { get; set; }

        /// <summary>
        /// Optional. Required if ContentType = Image | Video | Document. URL of media displayed above Text
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// Optional. Required if ContentType = Image | Video | Document. Media name (with extension, like file.pdf)
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Message buttons. Up to 3 buttons allowed, otherwise the message will not be rendered in WhatsApp
        /// </summary>
        public List<FlowButton> Buttons { get; set; } = new List<FlowButton>();

        public FlowButtonContent(FlowButtonContentType type, string text, string? header = null, string? caption = null, string? url = null, string? fileName = null, List<FlowButton>? buttons = null)
        {
            this.ContentType = type;
            this.Text = text;
            this.Header = header;
            this.Caption = caption;
            this.Url = url;
            this.FileName = fileName;
            if (buttons != null) this.Buttons = buttons;
        }
    }

    /// <summary>
    /// A single message button
    /// </summary>
    public class FlowButton
    {
        /// <summary>
        /// Button's title. It's also the value captured when uses choose an button option
        /// </summary>
        public string Title { get; set; }

        public FlowButton(string title)
        {
            Title = title;
        }
    }
}
