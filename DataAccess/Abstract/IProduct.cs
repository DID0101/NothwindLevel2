using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProduct: IEntityRepository<Product>
    {

       // List<Product> GetAll();
        //Repesitory Pattern 
        //Listeleme 
        //eklem 
        //Silme 
        // Guncelleme
    }
}
