using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using web3.Models;
using web3.Data;

namespace web3.Pages_Companies
{
    public class IndexModel : PageModel
    {
        private readonly CompanyContext _context;

        public IndexModel(CompanyContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get; set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}