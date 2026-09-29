using System;

public class PaymentTransaction
{
    // Private attributes (Encapsulation for secure mobile money data)
    private string _transactionId;
    private string _patientName;
    private string _phoneNumber; // LumiCash or EcoCash account number
    private double _amountInFbu;
    private DateTime _paymentDate;
    private bool _isSuccessful;

    // Constructor to initialize a new mobile money payment
    public PaymentTransaction(string transactionId, string patientName, string phoneNumber, double amount)
    {
        _transactionId = transactionId;
        _patientName = patientName;
        _phoneNumber = phoneNumber;
        _amountInFbu = amount;
        _paymentDate = DateTime.Now; // Captures the exact payment time
        _isSuccessful = false;        // Default status is pending until confirmed
    }

    // --- Getters (Controlled access to payment history) ---

    public string GetTransactionId()
    {
        return _transactionId;
    }

    public string GetPatientName()
    {
        return _patientName;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public double GetAmount()
    {
        return _amountInFbu;
    }

    public DateTime GetPaymentDate()
    {
        return _paymentDate;
    }

    public bool IsSuccessful()
    {
        return _isSuccessful;
    }

    // Method called when LumiCash or EcoCash API confirms the payment
    public void ConfirmPayment()
    {
        _isSuccessful = true;
    }

    // Method to display transaction invoice details on the console
    public void DisplayReceipt()
    {
        string paymentStatus = "";
        if (_isSuccessful)
        {
            status = "SUCCESSFUL / PAID";
        }
        else
        {
            status = "PENDING / FAILED";
        }

        Console.WriteLine("=== TELEMED BURUNDI - PAYMENT RECEIPT ===");
        Console.WriteLine("Transaction ID: " + _transactionId);
        Console.WriteLine("Date & Time:    " + _paymentDate);
        Console.WriteLine("Status:         " + paymentStatus);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Patient Name:   " + _patientName);
        Console.WriteLine("Phone Number:   " + _phoneNumber);
        Console.WriteLine("Total Amount:   " + _amountInFbu + " FBU");
        Console.WriteLine("=========================================");
    }
}