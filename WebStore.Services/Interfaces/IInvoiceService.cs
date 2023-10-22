using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebStore.Model;
using WebStore.ViewModels.VM;

namespace WebStore.Services.Interfaces
{
    public interface IInvoiceService
    {
        public Task<(IList<InvoiceVm> invoiceResults, bool isExtracted)?> GetInvoicesAsync(Expression<Func<Invoice, bool>>? filterExpression = null);
        public Task<(InvoiceVm invoice, bool isExtracted)?> GetInvoiceByIdAsync(Expression<Func<Invoice,bool>>? filterExpression =null);
    }
}