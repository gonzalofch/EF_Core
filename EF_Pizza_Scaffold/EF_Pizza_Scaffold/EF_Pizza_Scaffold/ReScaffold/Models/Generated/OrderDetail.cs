using System;
using System.Collections.Generic;

namespace EF_PizzaReScaffold.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    public int CustomerId { get; set; }

    public int? OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> InverseOrderDetailNavigation { get; set; } = new List<OrderDetail>();

    public virtual Order? Order { get; set; }

    public virtual OrderDetail? OrderDetailNavigation { get; set; }
}
