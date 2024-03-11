
namespace APIFun.Data
{
    public class EFFoodRepository : IFoodRepository
    {
        private MarriottFoodContext _context;
        public EFFoodRepository(MarriottFoodContext temp) 
        {
            _context = temp;
        }
        public IEnumerable<MarriottFood> Foods => _context.Foods;
    }
}
