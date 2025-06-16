namespace HealthManagement.SERVICE.DTOs;

public class PatientDiagnosisModel
{
    public int PatientDiagnosisId { get; set; }
    public DateTime? DateOfDiagnosis { get; set; }
    public string? PatientDiagnosisName { get; set; }
    //for more properties check main Entity of PatientDiagnosisModel
}