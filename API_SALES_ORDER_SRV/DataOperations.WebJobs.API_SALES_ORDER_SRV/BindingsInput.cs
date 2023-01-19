using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using DataOperations.OData; 
using API_SALES_ORDER_SRV; 
namespace DataOperations.Bindings.Generated
{

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPartnerTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPartnerTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPrElementTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPrElementTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderItemTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderItemTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderItemPartnerTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderItemPartnerTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderItemPrElementTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderItemPrElementTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderItemRelatedObjectTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderItemRelatedObjectTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderItemTextTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderItemTextTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderRelatedObjectTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderRelatedObjectTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderScheduleLineTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderScheduleLineTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SalesOrderTextTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SalesOrderTextTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_SALES_ORDER_SRV_A_SlsOrdPaymentPlanItemDetailsTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrder { get; set;}
        public Input_API_SALES_ORDER_SRV_A_SlsOrdPaymentPlanItemDetailsTypeAttribute(string SalesOrder) => this.SalesOrder = SalesOrder;
    }


}
