using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public void Add(DocSpecilityVM rec)
        {

            Doctor d = new Doctor();
            d.FirstName = rec.FirstName;
            d.LastName = rec.LastName;
            d.MobileNo = rec.MobileNo;
            d.IsAvailable = rec.IsAvailable;
            d.Address = rec.Address;
            d.DoctorExperience = rec.DoctorExperience;
            d.AreaID = rec.AreaID;
            d.PhotoPath = rec.PhotoPath;
            d.DoctorQualification = rec.DoctorQualification;
            d.Password = rec.Password;

            foreach (var temp in rec.Specilities)
            {
                DoctorSpeciality ds = new DoctorSpeciality();
                ds.SpecilityID = temp;
                d.DoctorSpecialities.Add(ds);
            }

            this.cc.Doctors.Add(d);
            this.cc.SaveChanges();
        }

        public void DeleteDoc(long id)
        {
            var docsp = this.cc.DoctorSpecialities.Where(p => p.DoctorID == id);
            foreach (var temp in docsp)
            {
                this.cc.DoctorSpecialities.Remove(temp);
            }

            var doc = this.cc.Doctors.Find(id);
            this.cc.Doctors.Remove(doc);
            this.cc.SaveChanges();
        }

        public void DetailsDoc(long id)
        {
            var v = from t in this.cc.Specilities
                    join
                   t1 in this.cc.DoctorSpecialities on
                   t.SpecilityID equals t1.DoctorSpecilityID
                    select new
                    {
                        t.SpecilityID,
                        t1.DoctorSpecilityID,
                        t1.DoctorID,
                        t1.Doctor.FirstName,
                        t1.Doctor.LastName,
                        t1.Doctor.MobileNo,
                        t1.Doctor.Address,
                        t1.Doctor.IsAvailable,
                        t1.Doctor.DoctorPhoto,
                        t1.Doctor.DoctorQualification,
                        t1.Doctor.Password,
                        t1.Doctor.Area.AreaID
                    };
            this.cc.Doctors.SingleOrDefault();
            this.cc.SaveChanges();
            //var docsp = this.cc.DoctorSpecialities.Where(p => p.DoctorID == id);
            //foreach (var temp in docsp)
            //{
            //    this.cc.DoctorSpecialities.Remove(temp);
            //}

            //var doc = this.cc.Doctors.Find(id);
            //this.cc.Doctors.Remove(doc);
            //this.cc.SaveChanges();
        }

        public void EditDoc(DocSpecilityVM rec)
        {
            var oldrec = this.cc.Doctors.Find(rec.DoctorID);
            oldrec.FirstName = rec.FirstName;
            oldrec.LastName = rec.LastName;
            oldrec.MobileNo = rec.MobileNo;
            oldrec.IsAvailable = rec.IsAvailable;
            oldrec.Address = rec.Address;
            oldrec.DoctorExperience = rec.DoctorExperience;
            oldrec.AreaID = rec.AreaID;
            oldrec.DoctorPhoto = rec.DoctorPhoto;
            oldrec.DoctorQualification = rec.DoctorQualification;
            oldrec.Password = rec.Password;
            var oldSpecility = this.cc.DoctorSpecialities.Where(p => p.DoctorID == rec.DoctorID);

            foreach (var temp in oldSpecility)
            {
                this.cc.DoctorSpecialities.Remove(temp);
            }

            foreach (var temp in rec.Specilities)
            {
                DoctorSpeciality ds = new DoctorSpeciality();
                ds.SpecilityID = temp;
                oldrec.DoctorSpecialities.Add(ds);
            }

            this.cc.SaveChanges();
        }

        public List<DocSpecilityVM> GetAllDoc()
        {
            var v = from t in this.cc.Doctors
                    select new DocSpecilityVM
                    {
                        DoctorID = t.DoctorID,
                        FirstName = t.FirstName,
                        LastName = t.LastName,
                        MobileNo = t.MobileNo,
                        IsAvailable = t.IsAvailable,
                        Address = t.Address,
                        DoctorExperience = t.DoctorExperience,
                        AreaID = t.AreaID,
                        SpecilityString = (from t1 in t.DoctorSpecialities
                                           select t1.Specility.SpecilityName).ToList(),
                        DoctorQualification = t.DoctorQualification
                    };

            return v.ToList();
        }

        public DocSpecilityVM GetByDocID(long id)
        {
            var res = from t in this.cc.Doctors
                      where t.DoctorID == id
                      select new DocSpecilityVM
                      {
                          DoctorID = id,
                          FirstName = t.FirstName,
                          LastName = t.LastName,
                          MobileNo = t.MobileNo,
                          IsAvailable = t.IsAvailable,
                          Address = t.Address,
                          DoctorExperience = t.DoctorExperience,
                          DoctorPhoto = t.DoctorPhoto,
                          DoctorQualification = t.DoctorQualification,
                          Password = t.Password,
                          AreaID = t.AreaID
                      };

            return res.FirstOrDefault();
        }

        //List<DocSpecilityVM> IDoctorRepo.GetByID(long id)
        //{
        //    var v = from t in this.cc.Doctors
        //            join t1 in this.cc.Areas on t.AreaID equals t1.AreaID
        //            join t2 in this.cc.Cities on t1.CityID equals t2.CityID
        //            join t3 in this.cc.Clinics on t2.CityID equals t3.ClinicID
        //            Si
        //}
    }
}
