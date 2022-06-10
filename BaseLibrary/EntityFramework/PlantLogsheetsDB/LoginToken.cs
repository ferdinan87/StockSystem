using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class LoginToken
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string? UserName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
