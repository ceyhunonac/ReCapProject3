using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IResult Add(Customer customer);

        IDataResult<List<Customer>> GetAllById(int costumerId);
    }
}
