using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CustomersData;

[PrimaryKey("IncidentId", "ProductCode")]
public partial class Registration
{
    [Key]
    [Column("IncidentID")]
    public int IncidentId { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string ProductCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal ItemTotal { get; set; }

    [ForeignKey("IncidentId")]
    [InverseProperty("Registrations")]
    public virtual Incident Incident { get; set; } = null!;

    [ForeignKey("ProductCode")]
    [InverseProperty("Registrations")]
    public virtual Product ProductCodeNavigation { get; set; } = null!;
}
