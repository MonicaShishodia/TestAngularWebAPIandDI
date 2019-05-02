using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Abstraction.Entity
{
   public class TestTable
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
    }
}
