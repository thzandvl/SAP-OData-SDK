using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using DataOperations.OData; 
using API_SALES_ORDER_SRV; 
namespace DataOperations.Bindings.Generated
{

    public static class BindingHelper {
        
        public static void ConfigureBindings(ExtensionConfigContext context, IOperationsDispatcher dispatcher)
        {
            
            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderTypeAttribute, A_SalesOrderType>((x) => dispatcher.GetAsync<A_SalesOrderType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderTypeAttribute, A_SalesOrderType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPartnerTypeAttribute, A_SalesOrderHeaderPartnerType>((x) => dispatcher.GetAsync<A_SalesOrderHeaderPartnerType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderHeaderPartnerTypeAttribute, A_SalesOrderHeaderPartnerType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPrElementTypeAttribute, A_SalesOrderHeaderPrElementType>((x) => dispatcher.GetAsync<A_SalesOrderHeaderPrElementType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderHeaderPrElementTypeAttribute, A_SalesOrderHeaderPrElementType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderItemTypeAttribute, A_SalesOrderItemType>((x) => dispatcher.GetAsync<A_SalesOrderItemType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderItemTypeAttribute, A_SalesOrderItemType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderItemPartnerTypeAttribute, A_SalesOrderItemPartnerType>((x) => dispatcher.GetAsync<A_SalesOrderItemPartnerType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderItemPartnerTypeAttribute, A_SalesOrderItemPartnerType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderItemPrElementTypeAttribute, A_SalesOrderItemPrElementType>((x) => dispatcher.GetAsync<A_SalesOrderItemPrElementType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderItemPrElementTypeAttribute, A_SalesOrderItemPrElementType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderItemRelatedObjectTypeAttribute, A_SalesOrderItemRelatedObjectType>((x) => dispatcher.GetAsync<A_SalesOrderItemRelatedObjectType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderItemRelatedObjectTypeAttribute, A_SalesOrderItemRelatedObjectType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderItemTextTypeAttribute, A_SalesOrderItemTextType>((x) => dispatcher.GetAsync<A_SalesOrderItemTextType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderItemTextTypeAttribute, A_SalesOrderItemTextType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderRelatedObjectTypeAttribute, A_SalesOrderRelatedObjectType>((x) => dispatcher.GetAsync<A_SalesOrderRelatedObjectType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderRelatedObjectTypeAttribute, A_SalesOrderRelatedObjectType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderScheduleLineTypeAttribute, A_SalesOrderScheduleLineType>((x) => dispatcher.GetAsync<A_SalesOrderScheduleLineType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderScheduleLineTypeAttribute, A_SalesOrderScheduleLineType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SalesOrderTextTypeAttribute, A_SalesOrderTextType>((x) => dispatcher.GetAsync<A_SalesOrderTextType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SalesOrderTextTypeAttribute, A_SalesOrderTextType>(dispatcher);

            context.BindToInput<Input_API_SALES_ORDER_SRV_A_SlsOrdPaymentPlanItemDetailsTypeAttribute, A_SlsOrdPaymentPlanItemDetailsType>((x) => dispatcher.GetAsync<A_SlsOrdPaymentPlanItemDetailsType>(x.SalesOrder).Result);
            context.BindToCollector<Output_API_SALES_ORDER_SRV_A_SlsOrdPaymentPlanItemDetailsTypeAttribute, A_SlsOrdPaymentPlanItemDetailsType>(dispatcher);

            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderAttribute, A_SalesOrder, API_SALES_ORDER_SRV.A_SalesOrderType>((x) => new A_SalesOrder(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPartnerAttribute, A_SalesOrderHeaderPartner, API_SALES_ORDER_SRV.A_SalesOrderHeaderPartnerType>((x) => new A_SalesOrderHeaderPartner(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderHeaderPrElementAttribute, A_SalesOrderHeaderPrElement, API_SALES_ORDER_SRV.A_SalesOrderHeaderPrElementType>((x) => new A_SalesOrderHeaderPrElement(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderItemAttribute, A_SalesOrderItem, API_SALES_ORDER_SRV.A_SalesOrderItemType>((x) => new A_SalesOrderItem(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderItemPartnerAttribute, A_SalesOrderItemPartner, API_SALES_ORDER_SRV.A_SalesOrderItemPartnerType>((x) => new A_SalesOrderItemPartner(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderItemPrElementAttribute, A_SalesOrderItemPrElement, API_SALES_ORDER_SRV.A_SalesOrderItemPrElementType>((x) => new A_SalesOrderItemPrElement(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderItemRelatedObjectAttribute, A_SalesOrderItemRelatedObject, API_SALES_ORDER_SRV.A_SalesOrderItemRelatedObjectType>((x) => new A_SalesOrderItemRelatedObject(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderItemTextAttribute, A_SalesOrderItemText, API_SALES_ORDER_SRV.A_SalesOrderItemTextType>((x) => new A_SalesOrderItemText(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderRelatedObjectAttribute, A_SalesOrderRelatedObject, API_SALES_ORDER_SRV.A_SalesOrderRelatedObjectType>((x) => new A_SalesOrderRelatedObject(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderScheduleLineAttribute, A_SalesOrderScheduleLine, API_SALES_ORDER_SRV.A_SalesOrderScheduleLineType>((x) => new A_SalesOrderScheduleLine(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SalesOrderTextAttribute, A_SalesOrderText, API_SALES_ORDER_SRV.A_SalesOrderTextType>((x) => new A_SalesOrderText(dispatcher));
            context.BindToInputSet<Input_API_SALES_ORDER_SRV_A_SlsOrdPaymentPlanItemDetailsAttribute, A_SlsOrdPaymentPlanItemDetails, API_SALES_ORDER_SRV.A_SlsOrdPaymentPlanItemDetailsType>((x) => new A_SlsOrdPaymentPlanItemDetails(dispatcher));

        }
   }
}
