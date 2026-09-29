# TeleMed Burundi - Secure Telemedicine & E-Pharmacy Ecosystem

TeleMed Burundi is an advanced healthcare platform designed to connect patients, doctors, and local pharmacies in Burundi. Built with C# and following strict Object-Oriented Programming (OOP) and Encapsulation principles, the system ensures data privacy, security, and high efficiency even on low-data connections.

## Project Architecture & Core Models

The backend data architecture is structured into 7 core secure models inside the `Models` folder:

1. **Patient.cs** - Manages secure patient registration, location mapping, and private medical history logs.
2. **Doctor.cs** - Controls physician profiles, real-time online availability, and secure medical license validation to prevent credential fraud.
3. **Medicine.cs** - Handles pharmacy inventory tracking, automated stock updates, and localized pricing in Burundian Francs (FBU).
4. **EmergencyAlert.cs** - A critical hospital ward alerting system that immediately routes patient emergencies to verified on-call specialist doctors.
5. **Appointment.cs** - Manages scheduling between patients and doctors, generating secure virtual video/audio call consulting rooms.
6. **Prescription.cs** - Automates the transfer of digital medical prescriptions from verified doctors directly to partner pharmacies for home delivery.
7. **PaymentTransaction.cs** - Handles secure mobile money integrations with local services like LumiCash and EcoCash to verify payments before consultations or medicine logistics.

## Key Features

- **Strict Data Encapsulation:** All internal attributes are kept private to protect patient confidentiality and avoid runtime crashes.
- **Doctor Verification Protocol:** Restricts access to sensitive medical operations unless the doctor's credentials are fully approved by administrative checks.
- **Mobile-First Design Strategy:** Tailored specifically for the local digital landscape in Burundi, optimized to run seamlessly across mobile networks.

## Technical Foundations
- **Language:** C# (.NET Core Framework)
- **Architecture:** Enterprise Object-Oriented Design (Models & Separation of Concerns)
- **Academic Context:** Developed as a practical application of advanced software design patterns studied at BYU-Idaho.
