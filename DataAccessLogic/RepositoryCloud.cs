using System.Collections.Generic;
using DataAccessLogic;
using Model = Models;
using Entity = DataAccessLogic.Entities;
using System.Linq;

public class RepositoryCloud : IRepository
{
    private Entity.DatabaseContext _context;
    public RepositoryCloud(Entity.DatabaseContext p_context)
    {
        _context = p_context;
    }

    public Model.Customer AddCustomer(Model.Customer p_customer)
    {

        _context.Customers.Add
            (
                new Entity.Customer()
                {
                    Name = p_customer.Name,
                    Address = p_customer.Address,
                    Email = p_customer.Email,
                    PhoneNumber = p_customer.PhoneNumber,

                }
            );

        //This method will save the changes made to the database
        _context.SaveChanges();

        return p_customer;
    }


    public List<Model.LineItems> ChangeLineItemsQuantity(List<Model.LineItems> p_lineItems, int p_location)
    {
        throw new System.NotImplementedException();
    }

    public List<Model.Products> GetAllProducts()
    {
        throw new System.NotImplementedException();
    }

    public List<Model.Customer> GetCustomerList()
    {
        throw new System.NotImplementedException();
    }
    public List<Model.StoreFront> GetStoreFrontList()
    {
        return _context.Storefronts.Select(store =>
        new Model.StoreFront()
        {
            Name = store.Name,
            Address = store.Address,
            Products = store.Lineitems.Select(item =>
                new Model.LineItems()
                {
                    Quantity = item.Quantity,
                    Product = new Models.Products()
                    {
                        Name = item.Product.Name,
                        Price = item.Product.Price,
                        Description = item.Product.Description,
                        Brand = item.Product.Brand,
                        Category = item.Product.Category,
                        ProductId = item.Product.ProductId
                    },
                    LineItemId = item.LineitemId
                }).ToList(),
            Orders = store.Orders.Select(order => new Models.Orders()
            {
                OrderId = order.OrderId,
                Address = order.Address,
                TotalPrice = order.TotalPrice
            }).ToList(),
            StorefrontId = store.StorefrontId
        }).ToList();
    }

    public Model.Orders PlaceOrder(Model.Customer p_customer, Model.Orders p_order)
    {
        // add order to customer's list of orders
        var customer = _context.Customers
                            .FirstOrDefault<Entity.Customer>(cust => cust.CustomerId == p_customer.CustomerId);
        customer.Orders.Add(new Entity.Order()
        {
            Address = p_order.Address,
            TotalPrice = p_order.TotalPrice,
            StorefrontId = p_order.StoreFrontId,
            CustomerId = p_order.CustomerId,
        });
        _context.SaveChanges();
        return p_order; ;
    }

    List<Model.Products> IRepository.GetAllProducts()
    {
        throw new System.NotImplementedException();
    }

    List<Model.Customer> IRepository.GetCustomerList()
    {
        throw new System.NotImplementedException();
    }

    List<Model.LineItems> IRepository.GetLineItemsList(int p_store)
    {
        return _context.Lineitems
                     .Where(li => li.StorefrontId == p_store)
                     .Select(item => new Model.LineItems()
                     {
                         Quantity = item.Quantity,
                         Product = new Models.Products()
                         {
                             Name = item.Product.Name,
                             Price = item.Product.Price,
                             Description = item.Product.Description,
                             Brand = item.Product.Brand,
                             Category = item.Product.Category,
                             ProductId = item.Product.ProductId
                         },
                         LineItemId = item.LineitemId
                     }).ToList();


    }

    List<Model.Products> IRepository.GetProductsList(int p_store)
    {
        throw new System.NotImplementedException();
    }

}