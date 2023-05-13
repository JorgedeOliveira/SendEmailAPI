using SendoEmailAPI.Json;

namespace SendoEmailAPI.Mapeamento
{
    public static class Mapper
    {
        public static EmailDTO EmailMapper(JsonEmail jsonEmail)
        {
            EmailDTO emailDTO = new EmailDTO()
            {
                FromEmail = jsonEmail.FromEmail,
                ToEmail = jsonEmail.ToEmail,
                Pwd = jsonEmail.Pwd,
                Subject = jsonEmail.Subject,
                Body = jsonEmail.Body
            };

            return emailDTO;
        } 
    }
}
