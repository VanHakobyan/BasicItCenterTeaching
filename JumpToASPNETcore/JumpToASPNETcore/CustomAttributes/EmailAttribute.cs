using System.ComponentModel.DataAnnotations;

namespace JumpToASPNETcore.CustomAttributes
{
    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute()
            : base(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}")
        {
            this.ErrorMessage = "Please provide a valid email address";
        }
    }
}
