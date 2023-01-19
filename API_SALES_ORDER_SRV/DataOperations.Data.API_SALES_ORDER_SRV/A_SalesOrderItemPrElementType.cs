//EntityType AutoGenerated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace API_SALES_ORDER_SRV
{

    public class A_SalesOrderItemPrElementType : BaseDTOWithIDAndETag
    {
        private string _SalesOrder;
        public string SalesOrder 
        { 
            get {
                return _SalesOrder;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SalesOrder cannot be null and must have a value.");
                }
                if(value.Length > 10)
                {
                    throw new ValidationException("SalesOrder cannot be longer than 10 characters.");
                }
                else
                {
                    _SalesOrder = value;
                }
            }
        }
        private string _SalesOrderItem;
        public string SalesOrderItem 
        { 
            get {
                return _SalesOrderItem;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("SalesOrderItem cannot be null and must have a value.");
                }
                if(value.Length > 6)
                {
                    throw new ValidationException("SalesOrderItem cannot be longer than 6 characters.");
                }
                else
                {
                    _SalesOrderItem = value;
                }
            }
        }
        private string _PricingProcedureStep;
        public string PricingProcedureStep 
        { 
            get {
                return _PricingProcedureStep;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PricingProcedureStep cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("PricingProcedureStep cannot be longer than 3 characters.");
                }
                else
                {
                    _PricingProcedureStep = value;
                }
            }
        }
        private string _PricingProcedureCounter;
        public string PricingProcedureCounter 
        { 
            get {
                return _PricingProcedureCounter;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PricingProcedureCounter cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("PricingProcedureCounter cannot be longer than 3 characters.");
                }
                else
                {
                    _PricingProcedureCounter = value;
                }
            }
        }
        private string _ConditionType;
        public string ConditionType 
        { 
            get {
                return _ConditionType;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionType cannot be null and must have a value.");
                }
                if(value.Length > 4)
                {
                    throw new ValidationException("ConditionType cannot be longer than 4 characters.");
                }
                else
                {
                    _ConditionType = value;
                }
            }
        }
        private string _PricingDateTime;
        public string PricingDateTime 
        { 
            get {
                return _PricingDateTime;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PricingDateTime cannot be null and must have a value.");
                }
                if(value.Length > 14)
                {
                    throw new ValidationException("PricingDateTime cannot be longer than 14 characters.");
                }
                else
                {
                    _PricingDateTime = value;
                }
            }
        }
        public Edm.Date PriceConditionDeterminationDte { get; set; }
        private string _ConditionCalculationType;
        public string ConditionCalculationType 
        { 
            get {
                return _ConditionCalculationType;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionCalculationType cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("ConditionCalculationType cannot be longer than 3 characters.");
                }
                else
                {
                    _ConditionCalculationType = value;
                }
            }
        }
        public decimal ConditionBaseValue { get; set; }
        public decimal ConditionRateValue { get; set; }
        private string _ConditionCurrency;
        public string ConditionCurrency 
        { 
            get {
                return _ConditionCurrency;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionCurrency cannot be null and must have a value.");
                }
                if(value.Length > 5)
                {
                    throw new ValidationException("ConditionCurrency cannot be longer than 5 characters.");
                }
                else
                {
                    _ConditionCurrency = value;
                }
            }
        }
        public decimal ConditionQuantity { get; set; }
        private string _ConditionQuantityUnit;
        public string ConditionQuantityUnit 
        { 
            get {
                return _ConditionQuantityUnit;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionQuantityUnit cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("ConditionQuantityUnit cannot be longer than 3 characters.");
                }
                else
                {
                    _ConditionQuantityUnit = value;
                }
            }
        }
        private string _ConditionQuantitySAPUnit;
        public string ConditionQuantitySAPUnit 
        { 
            get {
                return _ConditionQuantitySAPUnit;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionQuantitySAPUnit cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("ConditionQuantitySAPUnit cannot be longer than 3 characters.");
                }
                else
                {
                    _ConditionQuantitySAPUnit = value;
                }
            }
        }
        private string _ConditionQuantityISOUnit;
        public string ConditionQuantityISOUnit 
        { 
            get {
                return _ConditionQuantityISOUnit;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionQuantityISOUnit cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("ConditionQuantityISOUnit cannot be longer than 3 characters.");
                }
                else
                {
                    _ConditionQuantityISOUnit = value;
                }
            }
        }
        private string _ConditionCategory;
        public string ConditionCategory 
        { 
            get {
                return _ConditionCategory;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionCategory cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("ConditionCategory cannot be longer than 1 characters.");
                }
                else
                {
                    _ConditionCategory = value;
                }
            }
        }
        public Edm.Boolean ConditionIsForStatistics { get; set; }
        private string _PricingScaleType;
        public string PricingScaleType 
        { 
            get {
                return _PricingScaleType;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PricingScaleType cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("PricingScaleType cannot be longer than 1 characters.");
                }
                else
                {
                    _PricingScaleType = value;
                }
            }
        }
        public Edm.Boolean IsRelevantForAccrual { get; set; }
        private string _CndnIsRelevantForInvoiceList;
        public string CndnIsRelevantForInvoiceList 
        { 
            get {
                return _CndnIsRelevantForInvoiceList;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("CndnIsRelevantForInvoiceList cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("CndnIsRelevantForInvoiceList cannot be longer than 1 characters.");
                }
                else
                {
                    _CndnIsRelevantForInvoiceList = value;
                }
            }
        }
        private string _ConditionOrigin;
        public string ConditionOrigin 
        { 
            get {
                return _ConditionOrigin;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionOrigin cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("ConditionOrigin cannot be longer than 1 characters.");
                }
                else
                {
                    _ConditionOrigin = value;
                }
            }
        }
        private string _IsGroupCondition;
        public string IsGroupCondition 
        { 
            get {
                return _IsGroupCondition;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("IsGroupCondition cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("IsGroupCondition cannot be longer than 1 characters.");
                }
                else
                {
                    _IsGroupCondition = value;
                }
            }
        }
        private string _ConditionRecord;
        public string ConditionRecord 
        { 
            get {
                return _ConditionRecord;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionRecord cannot be null and must have a value.");
                }
                if(value.Length > 10)
                {
                    throw new ValidationException("ConditionRecord cannot be longer than 10 characters.");
                }
                else
                {
                    _ConditionRecord = value;
                }
            }
        }
        private string _ConditionSequentialNumber;
        public string ConditionSequentialNumber 
        { 
            get {
                return _ConditionSequentialNumber;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionSequentialNumber cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("ConditionSequentialNumber cannot be longer than 3 characters.");
                }
                else
                {
                    _ConditionSequentialNumber = value;
                }
            }
        }
        private string _TaxCode;
        public string TaxCode 
        { 
            get {
                return _TaxCode;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("TaxCode cannot be null and must have a value.");
                }
                if(value.Length > 2)
                {
                    throw new ValidationException("TaxCode cannot be longer than 2 characters.");
                }
                else
                {
                    _TaxCode = value;
                }
            }
        }
        private string _WithholdingTaxCode;
        public string WithholdingTaxCode 
        { 
            get {
                return _WithholdingTaxCode;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("WithholdingTaxCode cannot be null and must have a value.");
                }
                if(value.Length > 2)
                {
                    throw new ValidationException("WithholdingTaxCode cannot be longer than 2 characters.");
                }
                else
                {
                    _WithholdingTaxCode = value;
                }
            }
        }
        public decimal CndnRoundingOffDiffAmount { get; set; }
        public decimal ConditionAmount { get; set; }
        private string _TransactionCurrency;
        public string TransactionCurrency 
        { 
            get {
                return _TransactionCurrency;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("TransactionCurrency cannot be null and must have a value.");
                }
                if(value.Length > 5)
                {
                    throw new ValidationException("TransactionCurrency cannot be longer than 5 characters.");
                }
                else
                {
                    _TransactionCurrency = value;
                }
            }
        }
        private string _ConditionControl;
        public string ConditionControl 
        { 
            get {
                return _ConditionControl;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionControl cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("ConditionControl cannot be longer than 1 characters.");
                }
                else
                {
                    _ConditionControl = value;
                }
            }
        }
        private string _ConditionInactiveReason;
        public string ConditionInactiveReason 
        { 
            get {
                return _ConditionInactiveReason;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionInactiveReason cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("ConditionInactiveReason cannot be longer than 1 characters.");
                }
                else
                {
                    _ConditionInactiveReason = value;
                }
            }
        }
        private string _ConditionClass;
        public string ConditionClass 
        { 
            get {
                return _ConditionClass;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionClass cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("ConditionClass cannot be longer than 1 characters.");
                }
                else
                {
                    _ConditionClass = value;
                }
            }
        }
        private string _PrcgProcedureCounterForHeader;
        public string PrcgProcedureCounterForHeader 
        { 
            get {
                return _PrcgProcedureCounterForHeader;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PrcgProcedureCounterForHeader cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("PrcgProcedureCounterForHeader cannot be longer than 3 characters.");
                }
                else
                {
                    _PrcgProcedureCounterForHeader = value;
                }
            }
        }
        public Edm.Double FactorForConditionBasisValue { get; set; }
        private string _StructureCondition;
        public string StructureCondition 
        { 
            get {
                return _StructureCondition;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("StructureCondition cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("StructureCondition cannot be longer than 1 characters.");
                }
                else
                {
                    _StructureCondition = value;
                }
            }
        }
        public Edm.Double PeriodFactorForCndnBasisValue { get; set; }
        private string _PricingScaleBasis;
        public string PricingScaleBasis 
        { 
            get {
                return _PricingScaleBasis;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PricingScaleBasis cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("PricingScaleBasis cannot be longer than 3 characters.");
                }
                else
                {
                    _PricingScaleBasis = value;
                }
            }
        }
        public decimal ConditionScaleBasisValue { get; set; }
        private string _ConditionScaleBasisUnit;
        public string ConditionScaleBasisUnit 
        { 
            get {
                return _ConditionScaleBasisUnit;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionScaleBasisUnit cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("ConditionScaleBasisUnit cannot be longer than 3 characters.");
                }
                else
                {
                    _ConditionScaleBasisUnit = value;
                }
            }
        }
        private string _ConditionScaleBasisCurrency;
        public string ConditionScaleBasisCurrency 
        { 
            get {
                return _ConditionScaleBasisCurrency;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ConditionScaleBasisCurrency cannot be null and must have a value.");
                }
                if(value.Length > 5)
                {
                    throw new ValidationException("ConditionScaleBasisCurrency cannot be longer than 5 characters.");
                }
                else
                {
                    _ConditionScaleBasisCurrency = value;
                }
            }
        }
        public Edm.Boolean CndnIsRelevantForIntcoBilling { get; set; }
        public Edm.Boolean ConditionIsManuallyChanged { get; set; }
        public Edm.Boolean ConditionIsForConfiguration { get; set; }
        private string _VariantCondition;
        public string VariantCondition 
        { 
            get {
                return _VariantCondition;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("VariantCondition cannot be null and must have a value.");
                }
                if(value.Length > 26)
                {
                    throw new ValidationException("VariantCondition cannot be longer than 26 characters.");
                }
                else
                {
                    _VariantCondition = value;
                }
            }
        }
        public Deferred<API_SALES_ORDER_SRV.A_SalesOrderType> to_SalesOrder {get; set;}


        public Deferred<API_SALES_ORDER_SRV.A_SalesOrderItemType> to_SalesOrderItem {get; set;}


        protected override Dictionary<string, List<string>> ReferenceKeys 
        {   
            get 
            {
                var result = new Dictionary<string, List<string>>();
                result.Add("PrimaryKey", new List<string>() {"SalesOrder","SalesOrderItem","PricingProcedureStep","PricingProcedureCounter"});
                result.Add("to_SalesOrder", new List<string>() {"SalesOrder","SalesOrderItem","PricingProcedureStep","PricingProcedureCounter"});
                result.Add("to_SalesOrderItem", new List<string>() {"SalesOrder","SalesOrderItem","PricingProcedureStep","PricingProcedureCounter"});

                return result;
            }
        }


    }
}
