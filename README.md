# Hospital Management System (ASP.NET Core Razor Pages)

## Overview
Hospital Management System is a web application built with **ASP.NET Core Razor Pages**, **Entity Framework Core**, and **Identity Scaffolding**.  
The system aims to manage hospital data (hospitals, patients, doctors, medical records) with secure authentication, authorization, and account management.  

This project was developed as an **individual task required by ITI**.  
I built it completely by myself, and it was later reviewed and verified by the supervisor.

---

## Features
- **Authentication & Authorization**
  - User registration and login.
  - Account management: update, delete, and download personal information.
  - User profile icon in the navigation bar.
  - Identity scaffolding with user management support.
  - Role-based access control (Admin, Doctor, Patient, Nurse).

- **User & Role Management**
  - Create, assign, and manage roles.
  - Assign users to specific roles.
  - Different permissions for Admin, Doctor, Patient, and Nurse.

- **Hospital Management (CRUD Operations)**
  - Manage hospitals (Create, Read/Details, Update, Delete).
  - Manage patients (Create, Read/Details, Update, Delete).
  - Manage doctors (Create, Read/Details, Update, Delete).
  - Manage medical records (Create, Read/Details, Update, Delete).
  - Link entities with `AspNetUsers` to associate accounts with different roles.

---

## Technologies Used
- ASP.NET Core Razor Pages (.NET 8)
- Entity Framework Core
- Identity Scaffolding
- SQL Server
- Bootstrap

---

## Installation & Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/HospitalManagementSystem-RazorPages.git
