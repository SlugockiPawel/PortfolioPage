﻿namespace Portfolio.Models
{
    public class EmailSettings
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Host { get; set; } = default!;
        public int Port { get; set; } = default!;
    }
}