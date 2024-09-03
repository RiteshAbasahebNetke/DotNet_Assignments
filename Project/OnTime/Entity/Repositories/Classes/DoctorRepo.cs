using Core;
using Entity.Repositories.Interfaces;
using Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        public void Add(DocSpecilityVM rec,Int64 id)
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
                d.DoctorPhoto = rec.DoctorPhoto;
                d.DoctorQualification = rec.DoctorQualification;
                d.Password = rec.Password;

                foreach (var temp in rec.Specilities)
                {
                    DoctorSpeciality ds = new DoctorSpeciality();
                    ds.SpecilityID = temp;
                    d.DoctorSpecialities.Add(ds);
                }

                var r = this.cc.Doctors.Add(d);
                this.cc.SaveChanges();


            foreach(var DocClinic in rec.DoctorClinicSessions)
            {
                var startTime=DateTime.Parse(DocClinic.StartTime);
                var endTime=DateTime.Parse(DocClinic.EndTime);
                var timeInterval=DocClinic.TimeInterval;

                while (startTime < endTime)
                {
                    var dsc = new DoctorClinicSession
                    {   
                        DoctorID=d.DoctorID,
                        ClinicID = rec.ClinicID,
                        StartTime = startTime.ToString("HH:mm"),
                        EndTime = startTime.AddMinutes(timeInterval).ToString("HH:mm"),
                        TimeInterval = DocClinic.TimeInterval,
                        OpdSessionID = DocClinic.OpdSessionID
                    };
                    startTime = startTime.AddMinutes(timeInterval);
                    this.cc.DoctorClinicSessions.Add(dsc);                   
                }
            }

            this.cc.SaveChanges();
        }

        public ResultVM ChangePassword(ChangePasswordVM rec, long doctorid)
        {
            ResultVM res = new ResultVM();
            var arec = this.cc.Doctors.Find(doctorid);
            if (arec != null)
            {
                if (arec.Password == rec.OldPassword)
                {
                    arec.Password = rec.NewPassword;
                    this.cc.SaveChanges();
                    res.IsSuccess = true;
                    res.Message = "Password Changed Successfully..!";
                }
                else
                {
                    res.IsSuccess = false;
                    res.Message = "Invalid Old Password";
                }
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid User!";
            }
            return res;
        }

        public void DeleteDoc(long id)
        {
            var docsp = this.cc.DoctorSpecialities.Where(p => p.DoctorID == id);
            foreach (var temp in docsp)
            {
                this.cc.DoctorSpecialities.Remove(temp);
            }
            var dsc=this.cc.DoctorClinicSessions.Where(p => p.DoctorID == id);
            foreach (var temp in dsc)
            {
                this.cc.DoctorClinicSessions.Remove(temp);
            }
            var doc = this.cc.Doctors.Find(id);
            this.cc.Doctors.Remove(doc);
            this.cc.SaveChanges();
        }

        public void DetailsDoc(long id)
        {
            var v = from t in this.cc.Specilities join
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
            this.cc.Doctors.Where(p => p.DoctorID == id);
            this.cc.SaveChanges();
            
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

        public Doctor GetClinicByDoctor(long id)
        {
            return this.cc.Doctors.Include(p=>p.Area).FirstOrDefault(p=>p.DoctorID==id);
        }

        public Doctor GetDoctorForRate(long did)
        {
            return this.cc.Doctors.Where(p=>p.DoctorID==did).FirstOrDefault();
        }

        public IEnumerable<GetDoctorsVM> GetDoctors(long? CountryID, long? StateID, long? CityID, long? SpecialityID)
        {
            var v = from t in this.cc.Doctors
                    join t1
                   in this.cc.Areas on t.AreaID equals t1.AreaID
                    join
                   t2 in this.cc.Cities on t1.CityID equals t2.CityID
                    join
                 t3 in this.cc.States on t2.StateID equals t3.StateID
                    join
                 t4 in this.cc.Countries on t3.CountryID equals t4.CountryID
                    join
                 t5 in this.cc.DoctorSpecialities on t.DoctorID equals t5.DoctorID
                    join
                 t6 in this.cc.Specilities on t5.SpecilityID equals t6.SpecilityID
                    join
                   t7 in this.cc.Clinics on t2.CityID equals t7.CityID
                    select new GetDoctorsVM
                    {
                        DoctorID=t.DoctorID,
                        DoctorPhoto=t.DoctorPhoto,
                        FullName=t.FullName,
                        DoctorQualification=t.DoctorQualification,
                        DoctorExperience = t.DoctorExperience,
                        IsAvailable=t.IsAvailable,
                        SpecilityName=t6.SpecilityName,
                        ClinicID=t7.ClinicID,
                        ClinicName =t7.ClinicName
                    };

            return v.ToList();
        }

        public LoginResultVM Signin(LoginVM rec)
        {
            LoginResultVM re = new LoginResultVM();
            var arec = this.cc.Doctors.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);

            if (arec != null)
            {
                re.IsLoggedIn = true;
                re.LoggedInID = arec.DoctorID;
                re.LoggedInName = arec.FullName;
            }
            else
            {
                re.IsLoggedIn = false;
            }
            return re;
        }

        List<Doctor> IDoctorRepo.GetByDID(long id)
        {
            var v = from t in this.cc.Doctors
                    join t1 in this.cc.Areas on t.AreaID equals t1.AreaID
                    join t2 in this.cc.Cities on t1.CityID equals t2.CityID
                    join t3 in this.cc.Clinics on t2.CityID equals t3.CityID where
                    (from t4 in this.cc.Clinics select t4.ClinicID)
                      .Contains(id) && t3.ClinicID == id
                    select t;

            return v.ToList();
        }
    }
}
