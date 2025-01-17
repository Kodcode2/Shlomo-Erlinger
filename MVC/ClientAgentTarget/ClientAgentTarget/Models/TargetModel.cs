﻿using System.ComponentModel.DataAnnotations;

namespace ClientAgentTarget.Models
{
    public enum TargetStatus
    {
        Alive,
        OnTask,
        Dead
    }
    public class TargetModel
    {

        public long Id { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Required, StringLength(225, MinimumLength = 3)]
        public required string Image { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        public required string Role { get; set; }
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1;
        public TargetStatus TargetStatus { get; set; } = TargetStatus.Alive;
    }
}
