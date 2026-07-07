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
            if (!ValidateDateRange(from, to))
            {
                return null;
            }

            return reportRepository.GetSalesReport(from, to);
        }

        public DataTable GetStockReport()
        {
            return reportRepository.GetStockReport();
        }

        public DataTable GetCustomerOrderHistory()
        {
            return reportRepository.GetDeliveredOrders();
        }

        public decimal GetTotalSales(DateTime from, DateTime to)
        {
            if (!ValidateDateRange(from, to))
            {
                return 0;
            }
            return reportRepository.GetTotalSales(from, to);
        }

        public int GetTotalOrders(DateTime from, DateTime to)
        {
            if (!ValidateDateRange(from, to))
            {
                return 0;
            }
            return reportRepository.GetTotalOrders(from, to);
        }

        public int GetTotalStock()
        {
            return reportRepository.GetTotalStock();
        }

        private bool ValidateDateRange(DateTime from, DateTime to)
        {
            if (from > to)
            {
                return false;
            }

            if (to > DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }
}