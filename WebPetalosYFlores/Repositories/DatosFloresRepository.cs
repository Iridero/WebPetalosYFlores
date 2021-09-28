using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPetalosYFlores.Models;
using System.Linq.Expressions;

namespace WebPetalosYFlores.Repositories
{
    
    public class DatosFloresRepository
    {
        floresContext context;        
        public DatosFloresRepository(floresContext context)
        {
            this.context = context;
        }
        public IEnumerable<Datosflore> GetDatosFlores()
        {
            return context.Datosflores;
        }
        public Datosflore GetDatosById(int id)
        {
            return context.Datosflores.Include("Imagenesflores")
                .First(x => x.Idflor == id);
        }
    }
}
