﻿using lensLook.Dal.models;

namespace lensLook.Dal
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
    }
}
