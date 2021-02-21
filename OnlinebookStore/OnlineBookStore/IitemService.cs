using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CanteenFoodService
{
    [ServiceContract]
    public interface IitemService
    {
        [OperationContract]
        DataSet GetItem();
        [OperationContract]
        void AddItem(Item itemobj);
        [OperationContract]
        void UpdateItem(Item itemobj);
        [OperationContract]
        void RemoveItem(int id);
    }

    [ServiceContract]
    public interface IorderService
    {
        [OperationContract]
        DataSet GetAllOrderHistory();
        [OperationContract]
        void PlaceOrder(Order orderobj);
        [OperationContract]
        Order GetOrderDetail(int id);
    }


    [DataContract]
    public class Item
    {
        [DataMember]
        [Key]
        [Required]
        public int id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [Required]
        public string Description { get; set; }
        [DataMember]
        [Required]
        public int price { get; set; }
        [DataMember]
        [Required]
        public string Category { get; set; }
        [DataMember]
        [Required]
        public string status { get; set; }
    }

    [DataContract]
    public class Order
    {
        [DataMember]
        [Key]
        [Required]
        public int orderid { get; set; }


        [DataMember]
        [Required]
        public string PersonName { get; set; }


        [DataMember]
        [Required]
        public string ItemName { get; set; }


        [DataMember]
        [Required]
        public int Amount { get; set; }

        [DataMember]
        [Required]
        public string Comments { get; set; }

        [DataMember]
        [Required]
        public string status { get; set; }
    }
}
