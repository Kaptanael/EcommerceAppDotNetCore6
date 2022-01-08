namespace Ecommerce.Api.Setting
{
    public class JwtSetting
    {
        public string Secret { get; set; }
        public TimeSpan TokenLifeTime { get; set; }
    }
}
