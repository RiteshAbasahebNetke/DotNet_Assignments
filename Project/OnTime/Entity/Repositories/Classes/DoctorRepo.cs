using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories.Classes
{
    public class DoctorRepo:GenericRepo<Doctor>, IDoctorRepo
    {
        CompanyContext cc;
        public DoctorRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public void AddDoctor(DoctorVM rec)
        {
            throw new NotImplementedException();
        }

        public void DeleteDoctor(long id)
        {
            throw new NotImplementedException();
        }

        public void EditDoctor(DoctorVM rec)
        {
            throw new NotImplementedException();
        }

        public DoctorVM GetByDoctorID(long id)
        {
            throw new NotImplementedException();
        }

        List<DoctorVM> IDoctorRepo.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
