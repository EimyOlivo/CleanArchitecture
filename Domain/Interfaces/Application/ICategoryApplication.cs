using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Application
{
    public interface ICategoryApplication
    {
        void crearCategoria(Category category);
        List<Category> buscarCategoria();
    }
}
