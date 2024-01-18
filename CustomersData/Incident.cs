using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CustomersData;

public partial class Incident
{
    [Key]
    [Column("IncidentID")]
    public int IncidentId { get; set; }

    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IncidentDate { get; set; }

    [Column(TypeName = "money")]
    public decimal ProductTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal SalesTax { get; set; }

    [Column(TypeName = "money")]
    public decimal Shipping { get; set; }

    [Column(TypeName = "money")]
    public decimal IncidentTotal { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Incidents")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Incident")]
    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
