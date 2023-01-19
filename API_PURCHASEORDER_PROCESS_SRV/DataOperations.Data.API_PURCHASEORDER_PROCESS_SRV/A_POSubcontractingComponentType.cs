//EntityType AutoGenerated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace API_PURCHASEORDER_PROCESS_SRV
{

    public class A_POSubcontractingComponentType : BaseDTOWithIDAndETag
    {
        private string _PurchaseOrder;
        public string PurchaseOrder 
        { 
            get {
                return _PurchaseOrder;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PurchaseOrder cannot be null and must have a value.");
                }
                if(value.Length > 10)
                {
                    throw new ValidationException("PurchaseOrder cannot be longer than 10 characters.");
                }
                else
                {
                    _PurchaseOrder = value;
                }
            }
        }
        private string _PurchaseOrderItem;
        public string PurchaseOrderItem 
        { 
            get {
                return _PurchaseOrderItem;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("PurchaseOrderItem cannot be null and must have a value.");
                }
                if(value.Length > 5)
                {
                    throw new ValidationException("PurchaseOrderItem cannot be longer than 5 characters.");
                }
                else
                {
                    _PurchaseOrderItem = value;
                }
            }
        }
        private string _ScheduleLine;
        public string ScheduleLine 
        { 
            get {
                return _ScheduleLine;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ScheduleLine cannot be null and must have a value.");
                }
                if(value.Length > 4)
                {
                    throw new ValidationException("ScheduleLine cannot be longer than 4 characters.");
                }
                else
                {
                    _ScheduleLine = value;
                }
            }
        }
        private string _ReservationItem;
        public string ReservationItem 
        { 
            get {
                return _ReservationItem;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("ReservationItem cannot be null and must have a value.");
                }
                if(value.Length > 4)
                {
                    throw new ValidationException("ReservationItem cannot be longer than 4 characters.");
                }
                else
                {
                    _ReservationItem = value;
                }
            }
        }
        private string _RecordType;
        public string RecordType 
        { 
            get {
                return _RecordType;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("RecordType cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("RecordType cannot be longer than 1 characters.");
                }
                else
                {
                    _RecordType = value;
                }
            }
        }
        private string _Material;
        public string Material 
        { 
            get {
                return _Material;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Material cannot be null and must have a value.");
                }
                if(value.Length > 40)
                {
                    throw new ValidationException("Material cannot be longer than 40 characters.");
                }
                else
                {
                    _Material = value;
                }
            }
        }
        private string _BOMItemDescription;
        public string BOMItemDescription 
        { 
            get {
                return _BOMItemDescription;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("BOMItemDescription cannot be null and must have a value.");
                }
                if(value.Length > 40)
                {
                    throw new ValidationException("BOMItemDescription cannot be longer than 40 characters.");
                }
                else
                {
                    _BOMItemDescription = value;
                }
            }
        }
        public decimal RequiredQuantity { get; set; }
        private string _BaseUnit;
        public string BaseUnit 
        { 
            get {
                return _BaseUnit;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("BaseUnit cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("BaseUnit cannot be longer than 3 characters.");
                }
                else
                {
                    _BaseUnit = value;
                }
            }
        }
        public Edm.Date RequirementDate { get; set; }
        public decimal QuantityInEntryUnit { get; set; }
        private string _EntryUnit;
        public string EntryUnit 
        { 
            get {
                return _EntryUnit;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("EntryUnit cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("EntryUnit cannot be longer than 3 characters.");
                }
                else
                {
                    _EntryUnit = value;
                }
            }
        }
        public decimal WithdrawnQuantity { get; set; }
        private string _Plant;
        public string Plant 
        { 
            get {
                return _Plant;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Plant cannot be null and must have a value.");
                }
                if(value.Length > 4)
                {
                    throw new ValidationException("Plant cannot be longer than 4 characters.");
                }
                else
                {
                    _Plant = value;
                }
            }
        }
        private string _Batch;
        public string Batch 
        { 
            get {
                return _Batch;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Batch cannot be null and must have a value.");
                }
                if(value.Length > 10)
                {
                    throw new ValidationException("Batch cannot be longer than 10 characters.");
                }
                else
                {
                    _Batch = value;
                }
            }
        }
        protected override Dictionary<string, List<string>> ReferenceKeys 
        {   
            get 
            {
                var result = new Dictionary<string, List<string>>();
                result.Add("PrimaryKey", new List<string>() {"PurchaseOrder","PurchaseOrderItem","ScheduleLine","ReservationItem","RecordType"});

                return result;
            }
        }


    }
}
