using System;
using System.Collections.Generic;

namespace GymClub.Database.DbContextModels;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? JoinDate { get; set; }
}
