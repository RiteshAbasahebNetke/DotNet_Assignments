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
        List<DoctorVM> GetAll();
        void AddDoctor(DoctorVM rec);
        void EditDoctor(DoctorVM rec);
        void DeleteDoctor(Int64 id);   
        DoctorVM GetByDoctorID(Int64 id);
    }
    
}
