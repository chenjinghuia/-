using MyCompany.EntityFrameworkCore;

namespace MyCompany.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyCompanyDbContext _context;

        public TestDataBuilder(MyCompanyDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}