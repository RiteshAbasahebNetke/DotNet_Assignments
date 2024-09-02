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
    public class BookedAppointmentsRepo:GenericRepo<BookedAppointments>,IBookedAppointmentsRepo
    {
        CompanyContext cc;
        public BookedAppointmentsRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public void Add(BookAppVM rec)
        {
            BookedAppointments ba = new BookedAppointments();
            rec.AppointmentDate = DateTime.Now;
            rec.StartTime = ba.StartTime;
            rec.EndTime = ba.EndTime;
            rec.IsPaid = ba.IsPaid;
            rec.DoctorClinicSessionID= ba.DoctorClinicSessionID;
            rec.PatientID = ba.PatientID;

            this.cc.Add(rec);
            this.cc.SaveChanges();
        }
    }
}
