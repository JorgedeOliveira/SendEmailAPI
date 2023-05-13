using Microsoft.AspNetCore.Mvc;
using SendoEmailAPI.Json;
using SendoEmailAPI.Mapeamento;
using SendoEmailAPI.Transaction;
using System.Reflection.Metadata.Ecma335;

namespace SendoEmailAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendEmailController : ControllerBase
    {
        [HttpPost]
        public ActionResult SendEmail(JsonEmail jsonEmail)
        {
            
            try
            {
                EmailDTO emailDTO = Mapper.EmailMapper(jsonEmail);

                bool ishtml = false;

                bool response = SendoEmailTRA.SendEmail(emailDTO, ishtml);

                if (response == true)
                    return Ok("Deu certo");

            }
            catch
            {
                return Ok("Nao deu certo");
            }

            return Ok("Nao deu certo");

            
        }
    }
}