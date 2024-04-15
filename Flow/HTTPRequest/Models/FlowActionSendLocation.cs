namespace HTTPRequest.Models
{
    /// <summary>
    /// Location flow action. Sends a location message to user
    /// </summary>
    public class FlowActionSendLocation : FlowAction
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        /// <summary>
        /// A name that identifies the location. For example, Ninna Hub
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional. A text to send as complement to location. For example: Av. Dom Manuel, 1020
        /// </summary>
        public string? Address { get; set; }

        public FlowActionSendLocation(double latitude, double longitude, string name, string? address = null, int delay = 0) : base(FlowActionType.Location, delay)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Name = name;
            this.Address = address;
        }
    }
}
