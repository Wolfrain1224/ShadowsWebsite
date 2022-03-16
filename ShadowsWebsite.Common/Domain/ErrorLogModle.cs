using System;

namespace ShadowsWebsite.Common.Domain
{
    public class ErrorLogModle
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RealFirstname { get; set; }
        public string RealLastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}