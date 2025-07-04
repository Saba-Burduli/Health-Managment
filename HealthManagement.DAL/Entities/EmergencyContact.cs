﻿namespace HealthManagement.Infrastructure.Entities;

public class EmergencyContact
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? Relationship { get; set; }
    public string? Email { get; set; }
    
    //Relations :
    public List<Patient>? Patients { get; set; }
}