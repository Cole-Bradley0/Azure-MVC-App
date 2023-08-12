using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Azure_Web_App_Project.Models;

public partial class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [DisplayName("Code")]
    public int EmpCode { get; set; }

    [DisplayName("Name")]
    public string EmpName { get; set; } = null!;
    
    public string Designation { get; set; } = null!;

    public int Salary { get; set; }
}
