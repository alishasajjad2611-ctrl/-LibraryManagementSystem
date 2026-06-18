using App.Core.Models;
using System.Collections.Generic;

namespace App.Core.Interfaces
{
    public interface IIssueReturnService
    {
        List<IssueReturn> GetPendingIssues();
        void IssueBook(IssueReturn transaction);
        void ReturnBook(int bookId, int memberId);

       
        List<IssueReturn> SearchTransactions(string keyword);
    }
}