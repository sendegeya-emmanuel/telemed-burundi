using System;

public class Appointment
{
    // Private attributes (Encapsulation for data privacy)
    private string _appointmentId;
    private Patient _patient;       // Uses the Patient class object
    private Doctor _doctor;         // Uses the Doctor class object
    private DateTime _dateTime;
    private string _videoCallLink;  // Example: "https://telemed.bi"
    private string _status;         // Example: "Pending", "Confirmed", "Completed"

    // Constructor to schedule a new appointment
    public Appointment(string id, Patient patient, Doctor doctor, DateTime dateTime)
    {
        _appointmentId = id;
        _patient = patient;
        _doctor = doctor;
        _dateTime = dateTime;
        _videoCallLink = "https://telemed.bi" + id; // Generates a unique secure link
        _status = "Pending"; // Default status when created
    }

    // --- Getters and Setters (Controlled access to internal data) ---

    public string GetAppointmentId()
    {
        return _appointmentId;
    }

    public Patient GetPatient()
    {
        return _patient;
    }

    public Doctor GetDoctor()
    {
        return _doctor;
    }

    public DateTime GetDateTime()
    {
        return _dateTime;
    }

    public string GetVideoCallLink()
    {
        return _videoCallLink;
    }

    public string GetStatus()
    {
        return _status;
    }

    // Method to safely update the status (Confirmed, Completed, Canceled)
    public void SetStatus(string newStatus)
    {
        _status = newStatus;
    }

    // Method to display clean appointment details on the console
    public void DisplayAppointmentDetails()
    {
        Console.WriteLine("=== TELEMED BURUNDI - APPOINTMENT DETAILS ===");
        Console.WriteLine("Appointment ID: " + _appointmentId);
        Console.WriteLine("Date & Time:    " + _dateTime);
        Console.WriteLine("Status:         " + _status);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Patient:        " + _patient.GetFullName());
        Console.WriteLine("Doctor:         Dr. " + _doctor.GetFullName() + " (" + _doctor.GetSpecialty() + ")");
        Console.WriteLine("Secure Link:    " + _videoCallLink);
        Console.WriteLine("=============================================");
    }
}