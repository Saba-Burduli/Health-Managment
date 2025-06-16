using HealthManagement.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthManagement.Infrastructure;

public class HealthManagmentDBContext : DbContext
{
    
    public DbSet<PatientHealthInsurance> PatientHealthInsurances { get; set; } = null!;
    public DbSet<Person> Persons { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<Doctor> Doctors { get; set; } = null!;
    public DbSet<EmergencyContact> EmergencyContact { get; set; } = null!;
    public DbSet<Departament> Departaments { get; set; } = null!;
    public DbSet<HospitalDiagnosisList> HospitalDiagnosisLists { get; set; } = null!;
    public DbSet<PatientDiagnosis> PatientDiagnoses { get; set; } = null!;
    public DbSet<PatientHistory> PatientHistories { get; set; } = null!;

    public HealthManagmentDBContext(DbContextOptions<HealthManagmentDBContext> options) : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = 1,
                    RoleName = "Doctor",
                },
                new Role
                {
                    RoleId = 2,
                    RoleName = "Patient",
                });

            modelBuilder.Entity<PatientDiagnosis>().HasData(
                new PatientDiagnosis
                {
                    PatientDiagnosisId = 1,
                    PatientDiagnosisName = "Covid 19",
                    DateOfDiagnosis = new DateTime(2025, 3, 25) //this is not right 

                },
                new PatientDiagnosis
                {
                    PatientDiagnosisId = 2,
                    PatientDiagnosisName = "diabetes",
                    DateOfDiagnosis = new DateTime(2023, 4, 5)
                },
                new PatientDiagnosis
                {
                    PatientDiagnosisId = 3,
                    PatientDiagnosisName = "overweight",
                    DateOfDiagnosis = new DateTime(2022, 10, 19)
                });
        }
}