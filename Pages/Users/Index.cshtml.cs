#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab3.Models;


namespace Lab_3_Razor.Pages_Users
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StoreDBContext _context;

        public User? UserInfo { get; set; }

        public IndexModel(ILogger<IndexModel> logger, StoreDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            UserInfo = await _context.User.FirstOrDefaultAsync();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (UserInfo != null)
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                _context.Attach(UserInfo).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            _logger.Log(LogLevel.Information, UserInfo.Name);
            return RedirectToPage("./Index");
        }
    }
}
