using static Mango.web.Utility.SD;

namespace Mango.web.Models
{
    public class RequestDto
    {

        public ApiTye ApiType { get; set; } = ApiTye.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
