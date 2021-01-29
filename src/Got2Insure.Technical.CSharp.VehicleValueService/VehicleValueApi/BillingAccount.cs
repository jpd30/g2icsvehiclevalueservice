namespace Got2Insure.Technical.CSharp.VehicleValueService.VehicleValueApi
{
    internal class BillingAccount
    {
        public string AccountType { get; set; }

        public double AccountBalance { get; set; }

        public double TransactionCost { get; set; }

        public ExtraInformation ExtraInformation { get; set; }
    }
}
