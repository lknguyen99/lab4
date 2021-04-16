using Microsoft.Reporting.WinForms;
using QuanlyKho.Util;
using QuanLyKho.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmReport : Form
    {
        public Invoice invoice = new Invoice();
        public List<InventoryHistory> listReport = new List<InventoryHistory>(); 
        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(int kbn, Invoice invoice, List<InventoryHistory> listReport)
        {
            try
            {
                InitializeComponent();
                btnExport.Visible = (kbn == Constant.KBN_ORDER ? true : false);
                this.invoice = invoice;
                this.listReport = listReport;
                
                 if(kbn == Constant.KBN_LIST_ORDER )
                 {
                     btnExport.Text = Common.GetResouceString("BUTTON_IMPORT");

                     ReportParameter[] param = new ReportParameter[1];

                     param[0] = new ReportParameter("DeliveryDateStr", "AA");

                     this.reportViewer1.LocalReport.ReportPath = "Report/rptListOrder.rdlc";
                     this.reportViewer1.LocalReport.SetParameters(param);

                     var reportDataSource = new ReportDataSource("InventoryHistory", listReport);
                     this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                     this.reportViewer1.LocalReport.DisplayName = "Order List";
                }
                else if (invoice.InOutKbn == Constant.KBN_EXPORT || invoice.InOutKbn == Constant.KBN_ORDER)
                {
                    if (invoice.InOutKbn == null)
                        btnExport.Text = Common.GetResouceString("BUTTON_ORDER");
                    else
                        btnExport.Text = Common.GetResouceString("BUTTON_EXPORT");

                    ReportParameter[] param = new ReportParameter[12];
                    param[0] = new ReportParameter("DeliveryDateStr", string.Format(Constant.STR_DATE, invoice.DeliveryDate.Day, invoice.DeliveryDate.Month, invoice.DeliveryDate.Year));

                    param[1] = new ReportParameter("InvoiceNo", invoice.InvoiceNo);
                    param[2] = new ReportParameter("Amount", Common.GetMoney(invoice.Amount));

                    param[3] = new ReportParameter("Discount", Common.GetMoney(invoice.Amount - invoice.TotalAmount));

                    double discountPercent = 0;
                    if (invoice.Discount != null)
                        discountPercent = invoice.Discount.Value * 100;
                    param[4] = new ReportParameter("DiscountPercent", discountPercent.ToString());

                    param[5] = new ReportParameter("TotalAmount", Common.GetMoney(invoice.TotalAmount));


                    Employee findEmployee = Employee.GetEmployee(invoice.EmployeeID);

                    if (findEmployee == null)
                    {
                        findEmployee = new Employee();
                        findEmployee.FullName = invoice.EmployeeName;
                        findEmployee.EmployeeID = invoice.EmployeeID + ""; 
                    }
                    param[6] = new ReportParameter("EmployeeName", findEmployee.FullName);
                    param[7] = new ReportParameter("EmployeeMobile", findEmployee.Mobile);
                    param[8] = new ReportParameter("EmployeeID", findEmployee.EmployeeID);

                    Customer findCutomer = Customer.GetCustomer(invoice.CustomerID);
                    if (findCutomer == null)
                        findCutomer = new Customer();

                    param[9] = new ReportParameter("CustomerName", invoice.CustomerName);
                    param[10] = new ReportParameter("CustomerMobile", findCutomer.Mobile);
                    param[11] = new ReportParameter("CustomerAddress", findCutomer.Address);

                    this.reportViewer1.LocalReport.ReportPath = "Report/rptExport.rdlc";
                    this.reportViewer1.LocalReport.SetParameters(param);

                    var reportDataSource = new ReportDataSource("InventoryHistory", listReport);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.LocalReport.DisplayName = invoice.InvoiceNo;
 
                }
                else if (invoice.InOutKbn == Constant.KBN_IMPORT)
                {
                    btnExport.Text = Common.GetResouceString("BUTTON_IMPORT");

                    ReportParameter[] param = new ReportParameter[7];

                    param[0] = new ReportParameter("InvoiceNo", invoice.InvoiceNo);
                    param[1] = new ReportParameter("Amount", Common.GetMoney(invoice.Amount));
                    param[2] = new ReportParameter("Discount", Common.GetMoney(invoice.Amount - invoice.TotalAmount));

                    param[3] = new ReportParameter("TotalAmount", Common.GetMoney(invoice.TotalAmount));
                    double discountPercent = 0;
                    if (invoice.Discount != null)
                        discountPercent = invoice.Discount.Value * 100;
                    param[4] = new ReportParameter("DiscountPercent", discountPercent.ToString());


                    Employee findEmployee = Employee.GetEmployee(invoice.EmployeeID);

                    if (findEmployee == null)
                        findEmployee = new Employee();
                    param[5] = new ReportParameter("EmployeeName", findEmployee.FullName);
                    param[6] = new ReportParameter("EmployeeMobile", findEmployee.Mobile);

                    this.reportViewer1.LocalReport.ReportPath = "Report/rptImport.rdlc";
                    this.reportViewer1.LocalReport.SetParameters(param);
                    var reportDataSource = new ReportDataSource("InventoryHistory", listReport);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.LocalReport.DisplayName = invoice.InvoiceNo;
                }
                else if (invoice.InOutKbn == Constant.KBN_EXPORT_ALL)
                {
                    ReportParameter[] param = new ReportParameter[12];
                    param[0] = new ReportParameter("DeliveryDateStr", string.Format(Constant.STR_FROM_TO_DATE, invoice.OrderDate.ToString("dd/MM/yyyy"), invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                    param[1] = new ReportParameter("InvoiceNo", "");

                    param[2] = new ReportParameter("Amount", Common.GetMoney(invoice.Amount));
                    param[3] = new ReportParameter("Discount", Common.GetMoney(invoice.Amount - invoice.TotalAmount));

                    double discountPercent = 0;
                    if (invoice.Discount != null)
                        discountPercent = invoice.Discount.Value * 100;
                    param[4] = new ReportParameter("DiscountPercent", discountPercent.ToString());
                    param[5] = new ReportParameter("TotalAmount", Common.GetMoney(invoice.TotalAmount));


                    Employee findEmployee = Employee.GetEmployee(invoice.EmployeeID);
                    if (findEmployee == null)
                    {
                        findEmployee = new Employee();
                        findEmployee.FullName = invoice.EmployeeName;
                        findEmployee.EmployeeID = invoice.EmployeeID + "";
                    }
                    param[6] = new ReportParameter("EmployeeName", findEmployee.FullName);
                    param[7] = new ReportParameter("EmployeeMobile", findEmployee.Mobile);
                    param[8] = new ReportParameter("EmployeeID", findEmployee.EmployeeID);

                    Customer findCutomer = Customer.GetCustomer(invoice.CustomerID);
                    if (findCutomer == null)
                        findCutomer = new Customer();

                    param[9] = new ReportParameter("CustomerName", invoice.CustomerName);
                    param[10] = new ReportParameter("CustomerMobile", findCutomer.Mobile);
                    param[11] = new ReportParameter("CustomerAddress", findCutomer.Address);


                    this.reportViewer1.LocalReport.ReportPath = "Report/rptBangKeChiTiet.rdlc";
                    this.reportViewer1.LocalReport.SetParameters(param);

                    var reportDataSource = new ReportDataSource("InventoryHistory", listReport);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.LocalReport.DisplayName = invoice.InvoiceNo;
                }

   
               
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        public frmReport(DateTime dateFrom, DateTime dateTo, List<InventoryStore> listInventoryStore)
        {
            try
            {

                InitializeComponent();

                btnExport.Text = "";
                ReportParameter[] param = new ReportParameter[2];

                param[0] = new ReportParameter("DateFrom", Common.GetShortDate(dateFrom));
                param[1] = new ReportParameter("DateTo", Common.GetShortDate(dateTo));


                this.reportViewer1.LocalReport.ReportPath = "Report/rptInventory.rdlc";
                this.reportViewer1.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("InventoryStore", listInventoryStore);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "BaoCaoTonKho";
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
       
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try 
            {
                if (btnExport.Text == Common.GetResouceString("BUTTON_IMPORT"))
                {
                    InventoryHistory.ImportData(listReport, invoice);
                }
                else 
                {
                    InventoryHistory.ExportData(listReport, invoice);
                }
               
                FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_SUCCESS_EXPORT_INVENTORY"));
                this.Close();
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }


    }
}
