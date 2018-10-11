using System;
using System.Collections.Generic;

namespace ProvaTecnica.Entity.TransactionModel
{
    public class CustomerTransactionModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        IList<ProductTransactionModel> Products { get; set; }
    }
}
