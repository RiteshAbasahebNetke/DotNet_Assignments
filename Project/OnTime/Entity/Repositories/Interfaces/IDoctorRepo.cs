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

        Doctor GetDoctor(Int64 did);
        List<Doctor> GetByDID(Int64 id);
        void Add(DocSpecilityVM rec);
        List<DocSpecilityVM> GetAllDoc();
        DocSpecilityVM GetByDocID(Int64 id);
        void EditDoc(DocSpecilityVM rec);
        void DeleteDoc(Int64 id);
        //void DetailsDoc(Int64 id);
    }
       
}
