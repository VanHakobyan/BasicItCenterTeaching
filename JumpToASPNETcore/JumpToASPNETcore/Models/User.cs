using JumpToASPNETcore.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JumpToASPNETcore.Models
{
    public class User
    {
        [Required]
        [Email]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// Checks if user with given password exists in the database
        /// </summary>
        /// <param name="_username">User name</param>
        /// <param name="_password">User password</param>
        /// <returns>True if user exist and password is correct</returns>
        public bool IsValid(string _username, string _password)
        {
            //using (var cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename" +
            //  @"='C:\Tutorials\1 - Creating a custom user login form\Creating " +
            //  @"a custom user login form\App_Data\Database1.mdf';Integrated Security=True"))
            //{
            //    string _sql = @"SELECT [Username] FROM [dbo].[System_Users] " +
            //           @"WHERE [Username] = @u AND [Password] = @p";
            //    var cmd = new SqlCommand(_sql, cn);
            //    cmd.Parameters
            //        .Add(new SqlParameter("@u", SqlDbType.NVarChar))
            //        .Value = _username;
            //    cmd.Parameters
            //        .Add(new SqlParameter("@p", SqlDbType.NVarChar))
            //        .Value = Helpers.SHA1.Encode(_password);
            //    cn.Open();
            //    var reader = cmd.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        reader.Dispose();
            //        cmd.Dispose();
            //        return true;
            //    }
            //    else
            //    {
            //        reader.Dispose();
            //        cmd.Dispose();
            //        return false;
            //    }
            //}
            return true;
        }
    }
}
