using System;
using System.Collections.Generic;
using System.Linq;
using DataOperations;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace GWSAMPLE_BASIC
{
    public class TestService : BackgroundService, IHostedService
    {
        private readonly ILogger _logger;
        private readonly IOperationsDispatcher _dispatcher;
        public BusinessPartnerSet businessPartnerSet;
        public ProductSet productSet;
        public SalesOrderLineItemSet salesOrderLineItemSet;

        public TestService(ILogger<TestService> logger, IOperationsDispatcher dispatcher, SalesOrderLineItemSet _sos, ProductSet _ps, BusinessPartnerSet _bps
        )
        {
            _logger = logger;
            _dispatcher = dispatcher;
            this.salesOrderLineItemSet = _sos;
            this.productSet = _ps;
            this.businessPartnerSet = _bps;
        }
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            _logger.LogInformation("Test is starting...");

            // get product 'ht-1023'
            var product = await productSet.GetAsync("HT-1023");

            // get business partner '0100000001', update the address building to "16 Brook Meadow"
            var businessPartner = await businessPartnerSet.GetAsync("0100000001");
            businessPartner.Address.Building = "16 Brook Meadow";
            await businessPartnerSet.UpdateAsync(businessPartner);

            // Dump all salesOrderLineItem numbers to the console one by one (!)
            (await salesOrderLineItemSet.GetListAsync()).ToList().ForEach(salesOrderLineItem => {
                Console.WriteLine($"Sales Order: {salesOrderLineItem.SalesOrderID} / {salesOrderLineItem.ItemPosition} : {salesOrderLineItem.ProductID} / {salesOrderLineItem.Quantity} {salesOrderLineItem.QuantityUnit}");
            });

            // get me a sales order line item with id 0500000000 at position 10 and update the note to "Test Note"
            // be aware of required states of the sales orders in SAP for this service: https://blogs.sap.com/2019/06/06/es5-error-message-create-is-not-allowed-because-of-property-value/
            //var selectors = new Dictionary<string, object>();
            //selectors.Add("SalesOrderID", "0500000000");
            //selectors.Add("ItemPosition", "0000000010");
            //var salesOrderLineItem = await sos.GetAsync(selectors);
            //salesOrderLineItem.Note = "Test Note";
            //await sos.UpdateAsync(salesOrderLineItem);

            Product produc = await productSet.GetAsync("HT-1023");
            if(product.ProductID != "HT-1023") throw new Exception("Failed GET");
            _logger.LogInformation($"Poduct Description : ${product.Description}" );
            _logger.LogInformation("Test is complete.");
        }
    }
}
