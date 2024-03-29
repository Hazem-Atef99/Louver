﻿using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class UsersTeam
{
    public int Id { get; set; }

    public int? TeamId { get; set; }

    public int? UserId { get; set; }

    public virtual Team? Team { get; set; }

    public virtual User? User { get; set; }
}
