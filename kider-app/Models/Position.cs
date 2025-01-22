﻿using kider_app.Models.Common;

namespace kider_app.Models;

public class Position : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Agent> Agents { get; set; }
}
