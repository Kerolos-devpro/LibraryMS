using Microsoft.AspNetCore.Identity;

namespace LibraryMS.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;

    public byte[]? ProfilePictureUrl { get; set; } 

    public DateTime? DateOfBirth { get; set; } 

    public string? Address { get; set; }

    public string? NationalId { get; set; }

    public string? PreferredBranch { get; set; }

    public DateTime DateJoined { get; set; } = DateTime.UtcNow;

    public int CurrentBorrowedBooks { get; set; } 

    public int BorrowingLimit { get; set; } = 5; 


}
