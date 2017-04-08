using NinjectMvc.Abstract;

namespace NinjectMvc.Concrete
{
    public class Adventure : IBook
    {
        public string GetBookInformation()
        {
            return "this book is a great adventure";
        }
    }
}