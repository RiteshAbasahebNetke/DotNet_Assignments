using Core;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Entity
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt) { }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Admin>().HasData(
                new Admin() { AdminID=1,FirstName="Manoj",LastName="Patil",EmailID="manoj@hotmail.com",Password="abcd"}
                );

            foreach(var relationship in mb.Model.GetEntityTypes()
                .SelectMany(e=>e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<ClinicFacility> ClinicFacilities { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<OPDSession> OPDSessions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Specility> Specilities { get; set; }
        public DbSet<DoctorRating> DoctorRatings { get; set; }
        public DbSet<ClinicRating> ClinicRatings { get; set; }
        public DbSet<DoctorSpeciality> DoctorSpecialities { get; set; }
        public DbSet<ClinicCertificate> ClinicCertificates { get; set; }    
        public DbSet<DoctorClinicSession> DoctorClinicSessions { get; set; }
        public DbSet<BookedAppointments> BookedAppointments { get; set; }
        public DbSet<BookedAppPayment> BookedAppPayments { get; set; }
        public DbSet<AppointmentPrescription> AppointmentPrescription { get; set; }
        public DbSet<AppointmentPrescriptionDetails> AppointmentPrescriptionDetails { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
    }
}