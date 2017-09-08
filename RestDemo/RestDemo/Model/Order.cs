using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RestDemo.Model
{
  public class Order
  {

    // [JsonProperty("odata.type")]
    [JsonProperty("OrderID")]
    //[JsonRequired]
    public int OrderID { get; set; }

    public string CustomerID { get; set; }
    public int? EmployeeID { get; set; }
    public DateTime? OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public int? ShipVia { get; set; }
    public decimal? Freight { get; set; }
    public string ShipName { get; set; }
    public string ShipAddress { get; set; }
    public string ShipCity { get; set; }
    public string ShipRegion { get; set; }
    public string ShipPostalCode { get; set; }
    public string ShipCountry { get; set; }
  }

  public class ODataOrder
  {
    [JsonProperty("odata.metadata")]
    public string Metadata { get; set; }
    public List<Order> Value { get; set; }
  }
}