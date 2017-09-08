using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestDemo.Model
{
  public class Customer
  {// [JsonProperty("odata.type")]
    public string Type { set; get; }
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
  }

  public class OData
  {
    [JsonProperty("odata.metadata")]
    public string Metadata { get; set; }
    public List<Customer> Value { get; set; }
  }

  //public class CustomerJson
  //{
  //    [JsonProperty("customer")]
  //    public Customer Customer { get; set; }
  //}
}