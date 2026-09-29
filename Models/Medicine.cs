using System;

public class Medicine
{
    // Private attributes (Encapsulation to protect financial and stock data)
    private string _medicineId;
    private string _name;
    private double _priceInFbu;
    private int _stockQuantity;

    // Constructor to create a new medicine entry for the E-Pharmacy
    public Medicine(string id, string name, double price, int stock)
    {
        _medicineId = id;
        _name = name;
        _priceInFbu = price;
        _stockQuantity = stock;
    }

    // --- Getters and Setters (Controlled access to internal data) ---

    public string GetMedicineId()
    {
        return _medicineId;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _priceInFbu;
    }

    public int GetStock()
    {
        return _stockQuantity;
    }

    // Method to safely update the price of the medicine
    public void SetPrice(double newPrice)
    {
        if (newPrice >= 0)
        {
            _priceInFbu = newPrice;
        }
    }

    // Method to safely add new stock arriving at the partner pharmacy
    public void AddStock(int quantity)
    {
        if (quantity > 0)
        {
            _stockQuantity += quantity;
        }
    }

    // Method to reduce stock when a patient buys medicine via LumiCash/EcoCash
    public bool ReduceStock(int quantity)
    {
        if (quantity > 0 && quantity <= _stockQuantity)
        {
            _stockQuantity -= quantity;
            return true; // Action successful
        }
        else
        {
            Console.WriteLine("Error: Not enough stock available for " + _name);
            return false; // Action failed
        }
    }

    // Method to display clean medicine details on the console
    public void DisplayMedicineInfo()
    {
        Console.WriteLine("--- E-PHARMACY MEDICINE INFO ---");
        Console.WriteLine("Code:     " + _medicineId);
        Console.WriteLine("Name:     " + _name);
        Console.WriteLine("Price:    " + _priceInFbu + " FBU");
        Console.WriteLine("In Stock: " + _stockQuantity + " units");
        Console.WriteLine("--------------------------------");
    }
}