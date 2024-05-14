using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_Pizza_SQL_Server.Models;

[Index("CustomerId", Name = "IX_OrderDetails_CustomerId")]
[Index("OrderDetailId", Name = "IX_OrderDetails_OrderDetailId")]
[Index("OrderId", Name = "IX_OrderDetails_OrderId")]
public partial class OrderDetail
{
    [Key]
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    public int CustomerId { get; set; }

    public int? OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("OrderDetails")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("OrderDetailNavigation")]
    public virtual ICollection<OrderDetail> InverseOrderDetailNavigation { get; set; } = new List<OrderDetail>();

    [ForeignKey("OrderId")]
    [InverseProperty("OrderDetails")]
    public virtual Order? Order { get; set; }

    [ForeignKey("OrderDetailId")]
    [InverseProperty("InverseOrderDetailNavigation")]
    public virtual OrderDetail? OrderDetailNavigation { get; set; }
}
