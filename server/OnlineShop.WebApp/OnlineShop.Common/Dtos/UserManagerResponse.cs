namespace OnlineShop.Common.Dtos
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool IsSucces { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Token { get; set; }
        public bool IsAdmin { get; set; }

    }
}
