namespace HTTPRequest.Models
{
    /// <summary>
    /// Media flow action. Sends a message with media to user
    /// </summary>
    public class FlowActionSendMedia : FlowAction
    {
        /// <summary>
        /// Media type
        /// </summary>
        public FlowActionMediaType MediaType { get; set; }

        /// <summary>
        /// File's url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Optional. Caption to send above the file
        /// </summary>
        public string? Caption { get; set; }

        public FlowActionSendMedia(FlowActionMediaType mediaType, string url, string fileName, string? caption = null, int delay = 0) : base(FlowActionType.Media, delay)
        {
            this.MediaType = mediaType;
            this.Url = url;
            this.FileName = fileName;
            this.Caption = caption;
        }
    }
}
