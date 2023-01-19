using System.Threading.Tasks;
using DataOperations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using DataOperations.Bindings.Generated;
using GWSAMPLE_BASIC;

namespace FunctionsDemo
{
    //provided REST calls to test the bindings in odata-product-sample.http. Use with VS Code REST Client extension: https://marketplace.visualstudio.com/items?itemName=humao.rest-client
    public class SAPBindingDemo
    {
        [FunctionName("UpdateSalesOrderPrice")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "SalesOrderPriceUpdate/{ID}/{Price}")] HttpRequest req, ILogger log, int Price,
            [Input_GWSAMPLE_BASIC_SalesOrderAttribute("{ID}")] SalesOrder salesOrderInput,
            [Output_GWSAMPLE_BASIC_SalesOrderAttribute()] IAsyncCollector<SalesOrder> salesOrderCollector
        )
        {
            salesOrderInput.GrossAmount = Price;
            var AddressCity = (await salesOrderInput.ToBusinessPartner.GetAsync()).Address.City;
            await salesOrderCollector.AddAsync(salesOrderInput);
            return new OkObjectResult($"Updated Sales order price to {Price}, oh and the order will go to {AddressCity}");
        }
       
        [FunctionName("Products")]
        public async Task<IActionResult> RunProduct([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "Products/{top}")] HttpRequest req, ILogger log, int top,
        [Input_GWSAMPLE_BASIC_ProductSetAttribute()] ProductSet productListInput)
        {   
            return new OkObjectResult(
                await productListInput.GetListAsync(QueryTop.TopFactory(top), null, 
                    QueryOrderBy.OrderByFactory("ProductID"), 
                    QueryFilter.FilterFactory(new QueryFilterExpression("ProductID", FilterOperator.startswith,"HT")),null)
                );
        }

        [FunctionName("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "GetProduct/{ProductId}")] HttpRequest req, ILogger log,
            [Input_GWSAMPLE_BASIC_ProductAttribute("{ProductId}")] Product productInput,
            [Output_GWSAMPLE_BASIC_ProductAttribute()] IAsyncCollector<Product> productCollector)
        {
            productInput.Width = 100;
            await productCollector.AddAsync(productInput);

            return new OkObjectResult($"Product {productInput.ProductID} has been changed");
        }

        [FunctionName("AddProduct")]
        public async Task<IActionResult> AddProduct([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "AddProduct/{ProductId}")] HttpRequest req, ILogger log, string ProductId,
            [Output_GWSAMPLE_BASIC_ProductAttribute()] IAsyncCollector<Product> productCollector)
        {
            Product newProduct = new Product { ProductID = ProductId }; //ProductID = init only property
            newProduct.TypeCode = "PR";
            newProduct.Category = "Notebooks";
            newProduct.Name= "Notebook Basic 15";
            newProduct.NameLanguage = "EN";
            newProduct.Description = "Notebook Basic 15 with 2,80 GHz quad core, 15\" LCD, 4 GB DDR3 RAM, 500 GB Hard Disc, Windows 8 Pro";
            newProduct.DescriptionLanguage = "EN";
            newProduct.SupplierID = "0100000046";
            newProduct.SupplierName = "SAP";
            newProduct.TaxTarifCode = 1;
            newProduct.MeasureUnit = "EA";
            newProduct.WeightMeasure = 4;
            newProduct.WeightUnit = "KG";
            newProduct.CurrencyCode = "EUR";
            newProduct.Price = 956;
            newProduct.Width = 30;
            newProduct.Depth = 18;
            newProduct.Height = 3;
            newProduct.DimUnit = "CM";
            await productCollector.AddAsync(newProduct);
            return new OkObjectResult($"Product {ProductId} has been created!");
        }
    }
}
