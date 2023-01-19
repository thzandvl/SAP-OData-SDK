using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using DataOperations.OData; 
using API_PURCHASEORDER_PROCESS_SRV; 
namespace DataOperations.Bindings.Generated
{

    public static class BindingHelper {
        
        public static void ConfigureBindings(ExtensionConfigContext context, IOperationsDispatcher dispatcher)
        {
            
            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_POSubcontractingComponentTypeAttribute, A_POSubcontractingComponentType>((x) => dispatcher.GetAsync<A_POSubcontractingComponentType>(x.PurchaseOrder).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_POSubcontractingComponentTypeAttribute, A_POSubcontractingComponentType>(dispatcher);

            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderTypeAttribute, A_PurchaseOrderType>((x) => dispatcher.GetAsync<A_PurchaseOrderType>(x.PurchaseOrder).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderTypeAttribute, A_PurchaseOrderType>(dispatcher);

            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemTypeAttribute, A_PurchaseOrderItemType>((x) => dispatcher.GetAsync<A_PurchaseOrderItemType>(x.PurchaseOrder).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemTypeAttribute, A_PurchaseOrderItemType>(dispatcher);

            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemNoteTypeAttribute, A_PurchaseOrderItemNoteType>((x) => dispatcher.GetAsync<A_PurchaseOrderItemNoteType>(x.PurchaseOrder).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemNoteTypeAttribute, A_PurchaseOrderItemNoteType>(dispatcher);

            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderNoteTypeAttribute, A_PurchaseOrderNoteType>((x) => dispatcher.GetAsync<A_PurchaseOrderNoteType>(x.PurchaseOrder).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderNoteTypeAttribute, A_PurchaseOrderNoteType>(dispatcher);

            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderScheduleLineTypeAttribute, A_PurchaseOrderScheduleLineType>((x) => dispatcher.GetAsync<A_PurchaseOrderScheduleLineType>(x.PurchasingDocument).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderScheduleLineTypeAttribute, A_PurchaseOrderScheduleLineType>(dispatcher);

            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdAccountAssignmentTypeAttribute, A_PurOrdAccountAssignmentType>((x) => dispatcher.GetAsync<A_PurOrdAccountAssignmentType>(x.PurchaseOrder).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdAccountAssignmentTypeAttribute, A_PurOrdAccountAssignmentType>(dispatcher);

            context.BindToInput<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdPricingElementTypeAttribute, A_PurOrdPricingElementType>((x) => dispatcher.GetAsync<A_PurOrdPricingElementType>(x.PurchaseOrder).Result);
            context.BindToCollector<Output_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdPricingElementTypeAttribute, A_PurOrdPricingElementType>(dispatcher);

            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_POSubcontractingComponentAttribute, A_POSubcontractingComponent, API_PURCHASEORDER_PROCESS_SRV.A_POSubcontractingComponentType>((x) => new A_POSubcontractingComponent(dispatcher));
            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderAttribute, A_PurchaseOrder, API_PURCHASEORDER_PROCESS_SRV.A_PurchaseOrderType>((x) => new A_PurchaseOrder(dispatcher));
            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemAttribute, A_PurchaseOrderItem, API_PURCHASEORDER_PROCESS_SRV.A_PurchaseOrderItemType>((x) => new A_PurchaseOrderItem(dispatcher));
            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderItemNoteAttribute, A_PurchaseOrderItemNote, API_PURCHASEORDER_PROCESS_SRV.A_PurchaseOrderItemNoteType>((x) => new A_PurchaseOrderItemNote(dispatcher));
            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderNoteAttribute, A_PurchaseOrderNote, API_PURCHASEORDER_PROCESS_SRV.A_PurchaseOrderNoteType>((x) => new A_PurchaseOrderNote(dispatcher));
            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurchaseOrderScheduleLineAttribute, A_PurchaseOrderScheduleLine, API_PURCHASEORDER_PROCESS_SRV.A_PurchaseOrderScheduleLineType>((x) => new A_PurchaseOrderScheduleLine(dispatcher));
            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdAccountAssignmentAttribute, A_PurOrdAccountAssignment, API_PURCHASEORDER_PROCESS_SRV.A_PurOrdAccountAssignmentType>((x) => new A_PurOrdAccountAssignment(dispatcher));
            context.BindToInputSet<Input_API_PURCHASEORDER_PROCESS_SRV_A_PurOrdPricingElementAttribute, A_PurOrdPricingElement, API_PURCHASEORDER_PROCESS_SRV.A_PurOrdPricingElementType>((x) => new A_PurOrdPricingElement(dispatcher));

        }
   }
}
