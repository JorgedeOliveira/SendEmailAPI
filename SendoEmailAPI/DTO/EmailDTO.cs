namespace SendoEmailAPI.Json
{
    public class EmailDTO
    {
        public string FromEmail { get; set; }

        public string ToEmail { get; set; }

        public string Pwd { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
