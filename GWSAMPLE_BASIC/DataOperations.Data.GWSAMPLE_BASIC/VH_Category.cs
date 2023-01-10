//EntityType AutoGenerated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace GWSAMPLE_BASIC
{

    public class VH_Category : BaseDTOWithIDAndETag
    {
        private string _Category;
        public string Category 
        { 
            get {
                return _Category;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Category cannot be null and must have a value.");
                }
                if(value.Length > 40)
                {
                    throw new ValidationException("Category cannot be longer than 40 characters.");
                }
                else
                {
                    _Category = value;
                }
            }
        }
        protected override Dictionary<string, List<string>> ReferenceKeys 
        {   
            get 
            {
                var result = new Dictionary<string, List<string>>();
                result.Add("PrimaryKey", new List<string>() {"Category"});

                return result;
            }
        }


    }
}