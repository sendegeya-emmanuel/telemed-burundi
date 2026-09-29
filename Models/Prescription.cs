using System;
using System.Collections.Generic;

public class Prescription
{
    // Private attributes (Encapsulation for medical and stock data safety)
    private string _prescriptionId;
    private Patient _patient;
    private Doctor _doctor;
    private List<Medicine> _medicines;
    private DateTime _issuedDate;

    // Constructor to create a new medical prescription
    public Prescription(string id, Patient patient, Doctor doctor)
    {
        _prescriptionId = id;
        _patient = patient;
        _doctor = doctor;
        _medicines = new List<Medicine>();
        _issuedDate = DateTime.Now; // Captures the exact creation date
    }

    // --- Getters (Controlled access to internal data) ---

    public string GetPrescriptionId()
    {
        return _prescriptionId;
    }

    public Patient GetPatient()
    {
        return _patient;
    }

    public Doctor GetDoctor()
    {
        return _doctor;
    }

    public DateTime GetIssuedDate()
    {
        return _issuedDate;
    }

    public List<Medicine> GetMedicines()
    {
        return _medicines;
    }

    // Method to safely add a medicine to this prescription
    public void AddMedicine(Medicine medicine)
    {
        _medicines.Add(medicine);
    }

    // Method to display the clean prescription on the console
    public void DisplayPrescription()
    {
        Console.WriteLine("=== TELEMED BURUNDI - MEDICAL PRESCRIPTION ===");
        Console.WriteLine("Prescription ID: " + _prescriptionId);
        Console.WriteLine("Date Issued:     " + _issuedDate);
        Console.WriteLine("Doctor:          Dr. " + _doctor.GetFullName() + " (" + _doctor.GetSpecialty() + ")");
        Console.WriteLine("Patient:         " + _patient.GetFullName());
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Prescribed Medicines:");

        if (_medicines.Count == 0)
        {
            Console.WriteLine("No medicines added yet.");
        }
        else
        {
            foreach (Medicine med in _medicines)
            {
                Console.WriteLine("- " + med.GetName() + " (" + med.GetPrice() + " FBU)");
            }
        }
        Console.WriteLine("=============================================");
    }
}