﻿using Bookmazon.Shared.Models;
    
namespace Bookmazon.Server.Interfaces.Repos
{
    public interface ISupplierRepo
    {

        #region Supplier
        // Get 
        Task<IEnumerable<Supplier>> GetAllSuppliers();
        Task<Supplier?> GetSupplier(int supplierId);

        // Set
        void AddSupplier(Supplier supplier);
        void ConnectSupplierToBook(int supplierId, string ISBN);
        void RemoveSupplierFromBook(int supplierId, string ISBN);
        void UpdateSupplier(Supplier supplier);
        void RemoveSupplier(Supplier supplier);

        #endregion
    }
}
