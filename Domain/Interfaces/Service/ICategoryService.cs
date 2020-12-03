using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Service
{
    public interface ICategoryService
    {
        void crearCategoria(Category category);
        List<Category> buscarCategoria();
    }
}
