using Entity_Framework_Core01.Contexts;

namespace Entity_Framework_Core01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new ITIDbContext();
        }
    }
}
