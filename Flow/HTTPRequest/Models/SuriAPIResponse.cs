namespace HTTPRequest.Models
{
    public class SuriAPIResponse<T>
    {
        public bool Success { get; set; }

        public T? Data { get; set; }

        public string? Error { get; set; }
    }
}
