using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CustomersData;

public partial class Product
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProductCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal UnitPrice { get; set; }

    public int OnHandQuantity { get; set; }

    [InverseProperty("ProductCodeNavigation")]
    public virtual ICollection<Registrations> Registrationss { get; set; } = new List<Registrations>();
}
