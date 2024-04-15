namespace HTTPRequest.Models
{
    /// <summary>
    /// The button content type
    /// </summary>
    public enum FlowButtonContentType
    {
        /// <summary>
        /// A simple text button content sends only text (divided by header, body and caption) and the buttons itself
        /// </summary>
        Text = 0,

        /// <summary>
        /// A image button content displays an image, the text body and the buttons itself
        /// </summary>
        Image = 1,

        /// <summary>
        /// A video button content displays a video, the text body and the buttons itself
        /// </summary>
        Video = 2,

        /// <summary>
        /// A video button content displays a document, the text body and the buttons itself
        /// </summary>
        Document = 3
    }
}
