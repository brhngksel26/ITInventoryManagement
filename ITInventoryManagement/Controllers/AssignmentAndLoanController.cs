using ITInventoryManagement.Data;
using ITInventoryManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ITInventoryManagement.Controllers
{
    public class AssignmentAndLoanController : Controller
    {
        private readonly DataContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AssignmentAndLoanController(DataContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpPost("assign")]
        public async Task<IActionResult> AssignItem(string userId, [FromBody] Assignment assignment)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            var item = await _context.InventoryItems.FindAsync(assignment.InventoryItemId);
            if (item == null || item.IsAssigned)
            {
                return BadRequest("Item is either not found or already assigned.");
            }

            item.IsAssigned = true;
            assignment.User.Id = user.Id;
            assignment.AssignedDate = DateTime.UtcNow;

            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();

            return Ok(assignment);
        }

        [HttpPost("return")]
        public async Task<IActionResult> ReturnItem(int assignmentId)
        {
            var assignment = await _context.Assignments.FindAsync(assignmentId);
            if (assignment == null || assignment.IsReturned)
            {
                return BadRequest("Assignment not found or already returned.");
            }

            assignment.IsReturned = true;
            assignment.ReturnedDate = DateTime.UtcNow;

            var item = await _context.InventoryItems.FindAsync(assignment.InventoryItemId);
            item.IsAssigned = false;

            _context.Assignments.Update(assignment);
            await _context.SaveChangesAsync();

            return Ok(assignment);
        }

        [HttpPost("loan")]
        public async Task<IActionResult> LoanItem([FromBody] Loan loan)
        {
            var item = await _context.InventoryItems.FindAsync(loan.InventoryItemId);
            if (item == null || item.IsLoaned)
            {
                return BadRequest("Item is either not found or already loaned.");
            }

            item.IsLoaned = true;
            loan.LoanedDate = DateTime.UtcNow;

            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();

            return Ok(loan);
        }

        [HttpPost("loan-return")]
        public async Task<IActionResult> ReturnLoanItem(int loanId)
        {
            var loan = await _context.Loans.FindAsync(loanId);
            if (loan == null || loan.IsReturned)
            {
                return BadRequest("Loan not found or already returned.");
            }

            loan.IsReturned = true;
            loan.ReturnedDate = DateTime.UtcNow;

            var item = await _context.InventoryItems.FindAsync(loan.InventoryItemId);
            item.IsLoaned = false;

            _context.Loans.Update(loan);
            await _context.SaveChangesAsync();

            return Ok(loan);
        }
    }
}
