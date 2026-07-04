using SmartMedPharmacy.Repository;
using System;
using System.Data;

namespace SmartMedPharmacy.Controller
{
    public class ReportController
    {
        private ReportRepository reportRepository = new ReportRepository();

        public DataTable GetSalesReport(DateTime from, DateTime to)
        {
            return reportRepository.GetSalesReport(from, to);
        }

        public DataTable GetStockReport()
        {
            return reportRepository.GetStockReport();
        }

        public DataTable GetCustomerOrderHistory(string mobile)
        {
            return reportRepository.GetCustomerOrders(mobile);
        }

        public decimal GetTotalSales(DateTime from, DateTime to)
        {
            return reportRepository.GetTotalSales(from, to);
        }

        public int GetTotalOrders(DateTime from, DateTime to)
        {
            return reportRepository.GetTotalOrders(from, to);
        }

        public int GetTotalStock()
        {
            return reportRepository.GetTotalStock();
        }
    }
}