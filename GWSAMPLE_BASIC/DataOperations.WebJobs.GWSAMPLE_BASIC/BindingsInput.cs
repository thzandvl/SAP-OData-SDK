using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Config;
using DataOperations.OData; 
using GWSAMPLE_BASIC; 
namespace DataOperations.Bindings.Generated
{

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_BusinessPartnerAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string BusinessPartnerID { get; set;}
        public Input_GWSAMPLE_BASIC_BusinessPartnerAttribute(string BusinessPartnerID) => this.BusinessPartnerID = BusinessPartnerID;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_ProductAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string ProductID { get; set;}
        public Input_GWSAMPLE_BASIC_ProductAttribute(string ProductID) => this.ProductID = ProductID;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_SalesOrderAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrderID { get; set;}
        public Input_GWSAMPLE_BASIC_SalesOrderAttribute(string SalesOrderID) => this.SalesOrderID = SalesOrderID;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_SalesOrderLineItemAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string SalesOrderID { get; set;}
        public Input_GWSAMPLE_BASIC_SalesOrderLineItemAttribute(string SalesOrderID) => this.SalesOrderID = SalesOrderID;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_ContactAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string ContactGuid { get; set;}
        public Input_GWSAMPLE_BASIC_ContactAttribute(string ContactGuid) => this.ContactGuid = ContactGuid;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_SexAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Sex { get; set;}
        public Input_GWSAMPLE_BASIC_VH_SexAttribute(string Sex) => this.Sex = Sex;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_CountryAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Land1 { get; set;}
        public Input_GWSAMPLE_BASIC_VH_CountryAttribute(string Land1) => this.Land1 = Land1;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_AddressTypeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string AddressType { get; set;}
        public Input_GWSAMPLE_BASIC_VH_AddressTypeAttribute(string AddressType) => this.AddressType = AddressType;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_CategoryAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Category { get; set;}
        public Input_GWSAMPLE_BASIC_VH_CategoryAttribute(string Category) => this.Category = Category;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_CurrencyAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Waers { get; set;}
        public Input_GWSAMPLE_BASIC_VH_CurrencyAttribute(string Waers) => this.Waers = Waers;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_UnitQuantityAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Msehi { get; set;}
        public Input_GWSAMPLE_BASIC_VH_UnitQuantityAttribute(string Msehi) => this.Msehi = Msehi;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_UnitWeightAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Msehi { get; set;}
        public Input_GWSAMPLE_BASIC_VH_UnitWeightAttribute(string Msehi) => this.Msehi = Msehi;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_UnitLengthAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Msehi { get; set;}
        public Input_GWSAMPLE_BASIC_VH_UnitLengthAttribute(string Msehi) => this.Msehi = Msehi;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_ProductTypeCodeAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string TypeCode { get; set;}
        public Input_GWSAMPLE_BASIC_VH_ProductTypeCodeAttribute(string TypeCode) => this.TypeCode = TypeCode;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_BPRoleAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string BpRole { get; set;}
        public Input_GWSAMPLE_BASIC_VH_BPRoleAttribute(string BpRole) => this.BpRole = BpRole;
    }

    [Binding][AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)] 
    public class Input_GWSAMPLE_BASIC_VH_LanguageAttribute : Attribute, IInputAttribute 
    {
        [AutoResolve] public string Spras { get; set;}
        public Input_GWSAMPLE_BASIC_VH_LanguageAttribute(string Spras) => this.Spras = Spras;
    }


}
