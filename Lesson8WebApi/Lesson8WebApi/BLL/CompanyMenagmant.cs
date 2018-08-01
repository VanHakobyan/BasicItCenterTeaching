using Lesson8WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson8WebApi.BLL
{
    public class CompanyMenagmant
    {
        public List<MyModel> companies;
        public CompanyMenagmant()
        {
            companies = new List<MyModel>();
            SetCompanies();
        }
        private void SetCompanies()
        {
            var basicItCenter = new MyModel();

            basicItCenter.Id = 1;
            basicItCenter.CompanyName = "Basic IT Center";
            basicItCenter.CompanyEmail = "basic@it-center.am";

            companies.Add(basicItCenter);

            var microsoft = new MyModel()
            {
                Id = 2,
                CompanyName = "Microsoft",
                CompanyEmail = "Microsoft@microsoft.com",
            };

            companies.Add(microsoft);

            companies.Add(new MyModel { Id = 3, CompanyName = "Amazon", CompanyEmail = "amazon@amazon.com" });


        }
    }
}
