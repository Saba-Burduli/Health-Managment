using System.Collections.Immutable;
using HealthManagement.Infrastructure.Entities;
using HealthManagement.Infrastructure.Repositories;
using HealthManagement.SERVICE.DTOs;
using HealthManagement.SERVICE.Interfaces;

namespace HealthManagement.SERVICE.Services;

public class PatientService : IPatientService
{
    private readonly PatientRepository _patientRepository;
    public PatientService(PatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
    public async Task<IEnumerable<Patient>> GetALlPatientsAsync()
    {
        var patient = await _patientRepository.GetAllPatientsAsync();
        if (patient==null || !patient.Any())
        {
            throw new NullReferenceException("patients cannot be null");
        }

        var patientModel = patient.Select(p => new PatientModel()
        {
            PatiendId = p.PatientId,
            FirstName = p.FirstName,
            LastName = p.LastName,
            DateOfBirth = p.DateOfBirth,
            Address = p.Address,
            Phone = p.Phone,
            Email = p.Email
        });
        
        return await Task.FromResult(patient);
    }

    public async Task<Patient> GetPatientByIdAsync(int patientId)
    {
        var patient = await _patientRepository.GetPatientByIdAsync(patientId);
        if (patientId==null)
        {
            throw new NullReferenceException("Patient cannot be null");
        }

        var patientModel = new PatientModel()
        {
            PatiendId = patient.PatientId,
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            DateOfBirth = patient.DateOfBirth,
            Address = patient.Address,
            Phone = patient.Phone,
            Email = patient.Email
        };
        return await Task.FromResult(patient);
    }

    public async Task<Patient> AddPatientAsync(Patient patient)
    {
        var addPatient = _patientRepository.AddPatientAsync(patient);
        if (addPatient==null)
        {
            throw new NullReferenceException("patient cannot be null");
        }

        var patientModel = new PatientModel()
        {
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            DateOfBirth = patient.DateOfBirth,
            Address = patient.Address,
            Phone = patient.Phone,
            Email = patient.Email
        };
        return patient;
    }
    public async Task<Patient> UpdatePatientAsync(Patient patient)
    {
        await _patientRepository.UpdatePatientAsync(patient);
        
        if (patient == null)
        {
            throw new ArgumentNullException(nameof(patient));
        }
        
        var patientModel = new PatientModel()
        {
            PatiendId = patient.PatientId,
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            DateOfBirth = patient.DateOfBirth,
            Address = patient.Address,
            Phone = patient.Phone,
            Email = patient.Email
        };

        return patient;
    }
  
}