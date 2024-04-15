namespace HTTPRequest.Models
{
    /// <summary>
    /// Content of a list message
    /// </summary>
    public class FlowListContent
    {

        /// <summary>
        /// Text displayed above Body. Up to 60 characters allowed; markdown (*bold*, _italic_...) not allowed - otherwise it will not be rendered in WhatsApp.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The main text of message. It's usually a question whose answer options are the list options. Up to 1024 characters allowed, otherwise it will not be rendered in WhatsApp.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Main button title. After this button is clicked, all the list options are showed using a dialog/modal. Up to 20 characters allowed; markdown (*bold*, _italic_...) and emojis not allowed - otherwise it will not be rendered in WhatsApp.
        /// </summary>
        public string ButtonTitle { get; set; }

        /// <summary>
        /// Message list sections. A section is a virtual divider in a list,like categories. Up to 3 sections allowed, otherwise the message will not be rendered in WhatsApp
        /// For example: for a address list, a section could be the city or neighborhood.
        /// Section 1 => Center
        ///   Option 1 => Address 1
        ///   Option 2 => Address 2
        /// Section 2 => Neighborhood 1
        ///   Option 1 => Address 3
        /// </summary>
        public List<FlowListSection> Sections { get; set; }

        public FlowListContent(string title, string body, string buttonTitle, List<FlowListSection>? sections = null)
        {
            this.Title = title;
            this.Body = body;
            this.ButtonTitle = buttonTitle;
            this.Sections = sections ?? new List<FlowListSection>();
        }
    }
}
