using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using DataOperations.OData; 
using GWSAMPLE_BASIC; 
namespace DataOperations.Bindings.Generated
{

    public static class BindingHelper {
        
        public static void ConfigureBindings(ExtensionConfigContext context, IOperationsDispatcher dispatcher)
        {
            
            context.BindToInput<Input_GWSAMPLE_BASIC_BusinessPartnerAttribute, BusinessPartner>((x) => dispatcher.GetAsync<BusinessPartner>(x.BusinessPartnerID).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_BusinessPartnerAttribute, BusinessPartner>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_ProductAttribute, Product>((x) => dispatcher.GetAsync<Product>(x.ProductID).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_ProductAttribute, Product>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_SalesOrderAttribute, SalesOrder>((x) => dispatcher.GetAsync<SalesOrder>(x.SalesOrderID).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_SalesOrderAttribute, SalesOrder>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_SalesOrderLineItemAttribute, SalesOrderLineItem>((x) => dispatcher.GetAsync<SalesOrderLineItem>(x.SalesOrderID).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_SalesOrderLineItemAttribute, SalesOrderLineItem>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_ContactAttribute, Contact>((x) => dispatcher.GetAsync<Contact>(x.ContactGuid).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_ContactAttribute, Contact>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_SexAttribute, VH_Sex>((x) => dispatcher.GetAsync<VH_Sex>(x.Sex).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_SexAttribute, VH_Sex>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_CountryAttribute, VH_Country>((x) => dispatcher.GetAsync<VH_Country>(x.Land1).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_CountryAttribute, VH_Country>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_AddressTypeAttribute, VH_AddressType>((x) => dispatcher.GetAsync<VH_AddressType>(x.AddressType).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_AddressTypeAttribute, VH_AddressType>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_CategoryAttribute, VH_Category>((x) => dispatcher.GetAsync<VH_Category>(x.Category).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_CategoryAttribute, VH_Category>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_CurrencyAttribute, VH_Currency>((x) => dispatcher.GetAsync<VH_Currency>(x.Waers).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_CurrencyAttribute, VH_Currency>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_UnitQuantityAttribute, VH_UnitQuantity>((x) => dispatcher.GetAsync<VH_UnitQuantity>(x.Msehi).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_UnitQuantityAttribute, VH_UnitQuantity>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_UnitWeightAttribute, VH_UnitWeight>((x) => dispatcher.GetAsync<VH_UnitWeight>(x.Msehi).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_UnitWeightAttribute, VH_UnitWeight>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_UnitLengthAttribute, VH_UnitLength>((x) => dispatcher.GetAsync<VH_UnitLength>(x.Msehi).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_UnitLengthAttribute, VH_UnitLength>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_ProductTypeCodeAttribute, VH_ProductTypeCode>((x) => dispatcher.GetAsync<VH_ProductTypeCode>(x.TypeCode).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_ProductTypeCodeAttribute, VH_ProductTypeCode>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_BPRoleAttribute, VH_BPRole>((x) => dispatcher.GetAsync<VH_BPRole>(x.BpRole).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_BPRoleAttribute, VH_BPRole>(dispatcher);

            context.BindToInput<Input_GWSAMPLE_BASIC_VH_LanguageAttribute, VH_Language>((x) => dispatcher.GetAsync<VH_Language>(x.Spras).Result);
            context.BindToCollector<Output_GWSAMPLE_BASIC_VH_LanguageAttribute, VH_Language>(dispatcher);

            context.BindToInputSet<Input_GWSAMPLE_BASIC_BusinessPartnerSetAttribute, BusinessPartnerSet, GWSAMPLE_BASIC.BusinessPartner>((x) => new BusinessPartnerSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_ProductSetAttribute, ProductSet, GWSAMPLE_BASIC.Product>((x) => new ProductSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_SalesOrderSetAttribute, SalesOrderSet, GWSAMPLE_BASIC.SalesOrder>((x) => new SalesOrderSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_SalesOrderLineItemSetAttribute, SalesOrderLineItemSet, GWSAMPLE_BASIC.SalesOrderLineItem>((x) => new SalesOrderLineItemSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_ContactSetAttribute, ContactSet, GWSAMPLE_BASIC.Contact>((x) => new ContactSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_SexSetAttribute, VH_SexSet, GWSAMPLE_BASIC.VH_Sex>((x) => new VH_SexSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_CountrySetAttribute, VH_CountrySet, GWSAMPLE_BASIC.VH_Country>((x) => new VH_CountrySet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_AddressTypeSetAttribute, VH_AddressTypeSet, GWSAMPLE_BASIC.VH_AddressType>((x) => new VH_AddressTypeSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_CategorySetAttribute, VH_CategorySet, GWSAMPLE_BASIC.VH_Category>((x) => new VH_CategorySet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_CurrencySetAttribute, VH_CurrencySet, GWSAMPLE_BASIC.VH_Currency>((x) => new VH_CurrencySet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_UnitQuantitySetAttribute, VH_UnitQuantitySet, GWSAMPLE_BASIC.VH_UnitQuantity>((x) => new VH_UnitQuantitySet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_UnitWeightSetAttribute, VH_UnitWeightSet, GWSAMPLE_BASIC.VH_UnitWeight>((x) => new VH_UnitWeightSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_UnitLengthSetAttribute, VH_UnitLengthSet, GWSAMPLE_BASIC.VH_UnitLength>((x) => new VH_UnitLengthSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_ProductTypeCodeSetAttribute, VH_ProductTypeCodeSet, GWSAMPLE_BASIC.VH_ProductTypeCode>((x) => new VH_ProductTypeCodeSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_BPRoleSetAttribute, VH_BPRoleSet, GWSAMPLE_BASIC.VH_BPRole>((x) => new VH_BPRoleSet(dispatcher));
            context.BindToInputSet<Input_GWSAMPLE_BASIC_VH_LanguageSetAttribute, VH_LanguageSet, GWSAMPLE_BASIC.VH_Language>((x) => new VH_LanguageSet(dispatcher));

        }
   }
}
