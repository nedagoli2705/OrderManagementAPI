﻿using OrderManagement.CustomerContext.ApplicationService.Contract.Customers;

namespace OrderManagement.CustomerContext.Facade.Contract
{
    public interface ICustomerCommandFacade 
    {
        void CreateCustomer(CustomerCreateCommand command);
        void UpdateCustomer(CustomerUpdateCommand command);
        void DeleteCustomer(CustomerDeleteCommand command);
        void AddOrderToCustomer(AddOrderToCustomerCommand command);
        void UpdateOrderOfCustomer(UpdateOrderOfCustomerCommand command);
        void DeleteOrderFromCustomer(DeleteOrderFromCustomerCommand command);
    }
}
