using Core;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Interfaces
{
    public interface IDoctorRepo : IGenericRepo<Doctor> 
    {
        void Add(DocSpecilityVM rec);
        List<DocSpecilityVM> GetAllDoc();
        DocSpecilityVM GetByDocID(Int64 id);
        void EditDoc(DocSpecilityVM rec);
        void DeleteDoc(Int64 id);
    }
       
}
