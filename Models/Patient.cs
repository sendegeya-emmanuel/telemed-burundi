using System;
using System.Collections.Generic;

public class Patient
{
    // Private attributes (Encapsulation for data privacy)
    private string _patientId;
    private string _fullName;
    private string _phoneNumber;
    private string _location;
    private List<string> _medicalHistory;

    // Constructor to initialize a new patient profile
    public Patient(string id, string name, string phone, string location)
    {
        _patientId = id;
        _fullName = name;
        _phoneNumber = phone;
        _location = location;
        _medicalHistory = new List<string>();
    }

    // --- Getters and Setters (Controlled access to internal data) ---

    public string GetPatientId()
    {
        return _patientId;
    }

    public string GetFullName()
    {
        return _fullName;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public string GetLocation()
    {
        return _location;
    }

    // Method to safely update the patient's location
    public void SetLocation(string newLocation)
    {
        _location = newLocation;
    }

    // Method to add a disease or symptom to the patient's medical records
    public void AddMedicalCondition(string condition)
    {
        _medicalHistory.Add(condition);
    }

    // Method to get the list of medical records
    public List<string> GetMedicalHistory()
    {
        return _medicalHistory;
    }

    // Method to clear all text and display the clean profile on the console
    public void DisplayPatientProfile()
    {
        Console.WriteLine("=== TELEMED BURUNDI - PATIENT PROFILE ===");
        Console.WriteLine("Patient ID: " + _patientId);
        Console.WriteLine("Full Name:  " + _fullName);
        Console.WriteLine("Phone:      " + _phoneNumber);
        Console.WriteLine("Location:   " + _location);
        Console.WriteLine("Medical History: " + string.Join(", ", _medicalHistory));
        Console.WriteLine("=========================================");
    }
}