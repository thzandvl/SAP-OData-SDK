//EntityType AutoGenerated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace GWSAMPLE_BASIC
{

    public class VH_UnitQuantity : BaseDTOWithIDAndETag
    {
        private string _Msehi;
        public string Msehi 
        { 
            get {
                return _Msehi;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Msehi cannot be null and must have a value.");
                }
                if(value.Length > 3)
                {
                    throw new ValidationException("Msehi cannot be longer than 3 characters.");
                }
                else
                {
                    _Msehi = value;
                }
            }
        }
        private string _Msehl;
        public string Msehl 
        { 
            get {
                return _Msehl;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Msehl cannot be null and must have a value.");
                }
                if(value.Length > 30)
                {
                    throw new ValidationException("Msehl cannot be longer than 30 characters.");
                }
                else
                {
                    _Msehl = value;
                }
            }
        }
        protected override Dictionary<string, List<string>> ReferenceKeys 
        {   
            get 
            {
                var result = new Dictionary<string, List<string>>();
                result.Add("PrimaryKey", new List<string>() {"Msehi"});

                return result;
            }
        }


    }
}
