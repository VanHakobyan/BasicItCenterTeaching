using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson8WebApi.BLL;
using Lesson8WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace Lesson8WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static CompanyMenagmant companyMenagmant = new CompanyMenagmant();
        // GET api/values
        [HttpGet]
        public List<MyModel> Get()
        {
            return companyMenagmant.companies;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MyModel Get(int id)
        {
            //bad practice

            //for (int i = 1; i <= companyMenagmant.companies.Count; i++)
            //{
            //    if (id == companyMenagmant.companies[i].Id)
            //    {
            //        return companyMenagmant.companies[i];
            //    }
            //}
            //return null;

            //good practice
            return companyMenagmant.companies.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public List<MyModel> Post([FromBody]MyModel myModel)
        {
            companyMenagmant.companies.Add(myModel);
            return companyMenagmant.companies;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]MyModel myModel)
        {
            var selectedModel = companyMenagmant.companies.FirstOrDefault(x => x.Id == id);
            if (selectedModel is null) return BadRequest();
            companyMenagmant.companies.Remove(selectedModel);
            companyMenagmant.companies.Add(myModel);
            return Ok(myModel);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var selectedCompany = companyMenagmant.companies.FirstOrDefault(x => x.Id == id);
            if (selectedCompany is null) return BadRequest();
            companyMenagmant.companies.Remove(selectedCompany);
            return Ok(selectedCompany);
        }
    }
}
