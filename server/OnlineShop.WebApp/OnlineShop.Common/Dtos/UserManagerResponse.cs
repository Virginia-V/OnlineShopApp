namespace OnlineShop.Common.Dtos
{
    public class UserManagerResponse
    {
        public bool IsSucces { get; set; }
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsAdmin { get; set; }
        public List<string> Errors { get; set; }

    }
}
