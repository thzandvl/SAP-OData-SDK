using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using DataOperations.OData; 
using API_PURCHASEORDER_PROCESS_SRV; 
namespace DataOperations.Bindings.Generated
{

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_POSubcontractingComponentTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchaseOrder { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_POSubcontractingComponentTypeAttribute(string PurchaseOrder) => this.PurchaseOrder = PurchaseOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchaseOrder { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderTypeAttribute(string PurchaseOrder) => this.PurchaseOrder = PurchaseOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchaseOrder { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemTypeAttribute(string PurchaseOrder) => this.PurchaseOrder = PurchaseOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemNoteTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchaseOrder { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemNoteTypeAttribute(string PurchaseOrder) => this.PurchaseOrder = PurchaseOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderNoteTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchaseOrder { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderNoteTypeAttribute(string PurchaseOrder) => this.PurchaseOrder = PurchaseOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderScheduleLineTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchasingDocument { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderScheduleLineTypeAttribute(string PurchasingDocument) => this.PurchasingDocument = PurchasingDocument;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdAccountAssignmentTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchaseOrder { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdAccountAssignmentTypeAttribute(string PurchaseOrder) => this.PurchaseOrder = PurchaseOrder;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdPricingElementTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string PurchaseOrder { get; set;}
        public Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdPricingElementTypeAttribute(string PurchaseOrder) => this.PurchaseOrder = PurchaseOrder;
    }


}
