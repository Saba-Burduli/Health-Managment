﻿namespace HealthManagement.Infrastructure.Entities;

public class Departament
{
    public int DepartamentId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Notes { get; set; }
    
    //Relations:
    public List<HospitalDiagnosisList>? HospitalDiagnosisLists { get; set; }
    public List<Doctor>? Doctors { get; set; }
}