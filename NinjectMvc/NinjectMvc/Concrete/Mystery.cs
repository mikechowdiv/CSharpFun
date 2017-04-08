namespace NinjectMvc.Abstract
{
    public class Mystery : IBook
    {
        public string GetBookInformation()
        {
            return "this mystery book will keep you guessing";
        }
    }
}