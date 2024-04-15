namespace HTTPRequest.Models
{
    public class FlowListSection
    {
        /// <summary>
        /// List title. Up to 24 characters allowed; markdown (*bold*, _italic_...) and emojis not allowed - otherwise it will not be rendered in WhatsApp.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Optional. The section description showed below title.
        /// </summary>
        public string? Subtitle { get; set; }

        /// <summary>
        /// List options. A list option is also the value captured qhen user selects the option. Up to 10 options allowed couting all the sections: the summarize of options of all sections must be equal or less 10, otherwise it will not be rendered in WhatsApp.
        /// </summary>
        public List<FlowOption> Options { get; set; }

        public FlowListSection(string title, string? subtitle = null, List<FlowOption>? options = null)
        {
            this.Title = title;
            this.Subtitle = subtitle;
            this.Options = options ?? new List<FlowOption>();
        }
    }

    /// <summary>
    /// A single list option
    /// </summary>
    public class FlowOption
    {
        /// <summary>
        /// Option's title. It's also the value captured when uses choose an option. Up to 24 characters allowed; markdown (*bold*, _italic_...) and emojis not allowed - otherwise it will not be rendered in WhatsApp.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Optional. Option's description. Up to 70 characters allowed; markdown (*bold*, _italic_...) and emojis not allowed - otherwise it will not be rendered in WhatsApp.
        /// </summary>
        public string? Description { get; set; }

        public FlowOption(string title , string? description)
        {
            Title = title;
            Description = description;
        }
    }
}
