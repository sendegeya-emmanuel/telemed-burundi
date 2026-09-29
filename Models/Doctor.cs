using System;

public class Doctor
{
    // Private attributes (Encapsulation for international security standards)
    private string _doctorId;
    private string _fullName;
    private string _specialty;
    private string _medicalLicenseNumber;
    private string _hospitalAffiliation;
    private string _nationalIdCard;             // Burundi National ID (CNI) for proof of identity
    private string _licenseImageCertificatePath; // Path to the uploaded physical scan of the certificate
    private bool _isAvailable;
    private bool _isVerified;

    // Constructor to onboard a new doctor and collect original proof documents
    public Doctor(string id, string name, string specialty, string licenseNumber, string hospital, string cni, string imagePath)
    {
        _doctorId = id;
        _fullName = name;
        _specialty = specialty;
        _medicalLicenseNumber = licenseNumber;
        _hospitalAffiliation = hospital;
        _nationalIdCard = cni;
        _licenseImageCertificatePath = imagePath; // Links the original scanned file
        _isAvailable = true;
        _isVerified = false; // Remains false until the admin double-checks the physical certificate
    }

    // --- Getters and Setters for Security and Auditing ---

    public string GetDoctorId()
    {
        return _doctorId;
    }

    public string GetFullName()
    {
        return _fullName;
    }

    public string GetMedicalLicenseNumber()
    {
        return _medicalLicenseNumber;
    }

    public string GetNationalIdCard()
    {
        return _nationalIdCard;
    }

    public string GetLicenseImageCertificatePath()
    {
        return _licenseImageCertificatePath;
    }

    public bool IsVerified()
    {
        return _isVerified;
    }

    public void SetAvailability(bool availability)
    {
        _isAvailable = availability;
    }

    // Admin verifies the doctor ONLY after checking that the uploaded document matches MINISANTE registry
    public void VerifyDoctor()
    {
        if (_licenseImageCertificatePath != "" && _medicalLicenseNumber != "")
        {
            _isVerified = true;
        }
    }

    // Display profile including secure document verification status
    public void DisplayDoctorProfile()
    {
        string statusText = _isAvailable ? "AVAILABLE (Online)" : "BUSY (In Consultation)";
        string verificationText = _isVerified ? "VERIFIED (Original Documents Approved)" : "REJECTED / PENDING VERIFICATION";

        Console.WriteLine("=== TELEMED BURUNDI - SECURE DOCTOR PROFILE ===");
        Console.WriteLine("ID:               " + _doctorId);
        Console.WriteLine("Name:             Dr. " + _fullName);
        Console.WriteLine("Specialty:        " + _specialty);
        Console.WriteLine("Facility/Work:    " + _medicalFacility);
        Console.WriteLine("Burundi CNI:      " + _nationalIdCard);
        Console.WriteLine("License No:       " + _medicalLicenseNumber);
        Console.WriteLine("Certificate File: " + _licenseImageCertificatePath);
        Console.WriteLine("Status:           " + statusText);
        Console.WriteLine("Security Check:   " + verificationText);
        Console.WriteLine("=================================================");
    }
}