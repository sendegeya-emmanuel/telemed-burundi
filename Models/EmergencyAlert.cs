using System;

public class EmergencyAlert
{
    // Private attributes (Encapsulation for medical data security)
    private string _alertId;
    private Patient _patient;       // Uses the Patient class object
    private string _hospitalWard;   // Example: "Room 4, Intensive Care Unit"
    private string _severityLevel;  // Example: "CRITICAL", "HIGH", "MEDIUM"
    private DateTime _timestamp;
    private bool _isResolved;

    // Constructor to create a new hospital emergency alert
    public EmergencyAlert(string alertId, Patient patient, string ward, string severity)
    {
        _alertId = alertId;
        _patient = patient;
        _hospitalWard = ward;
        _severityLevel = severity;
        _timestamp = DateTime.Now;  // Captures the exact local time and date
        _isResolved = false;         // Default status is active / untamed
    }

    // --- Getters and Setters (Controlled access to internal data) ---

    public string GetAlertId()
    {
        return _alertId;
    }

    public string GetHospitalWard()
    {
        return _hospitalWard;
    }

    public string GetSeverityLevel()
    {
        return _severityLevel;
    }

    public bool IsResolved()
    {
        return _isResolved;
    }

    // Method to close the alert after the specialist doctor helps the patient
    public void ResolveAlert()
    {
        _isResolved = true;
    }

    // Method to send the alert to a specialist doctor and check their verification
    public void SendToDoctor(Doctor doctor)
    {
        // Security check: If the doctor is not verified, block the medical data
        if (doctor.IsVerified() == false)
        {
            Console.WriteLine("SECURITY ERROR: Access Denied. Cannot send critical patient data to unverified account: Dr. " + doctor.GetFullName());
            return;
        }

        // If verified, display the complete emergency details to the doctor
        Console.WriteLine("=== TELEMED BURUNDI - HOSPITAL EMERGENCY ALERT ===");
        Console.WriteLine("Alert ID: " + _alertId);
        Console.WriteLine("Severity: " + _severityLevel + " [ACTIVE]");
        Console.WriteLine("Time:     " + _timestamp);
        Console.WriteLine("Location: " + _hospitalWard);
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Patient Name: " + _patient.GetFullName());
        Console.WriteLine("Patient Phone: " + _patient.GetPhoneNumber());
        Console.WriteLine("Assigned Doctor: Dr. " + doctor.GetFullName() + " (" + doctor.GetSpecialty() + ")");
        Console.WriteLine("=================================================");
    }
}