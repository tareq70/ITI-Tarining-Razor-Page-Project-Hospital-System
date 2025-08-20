# Hospital Management System (ASP.NET Core Razor Pages)

## Overview
Hospital Management System is a web application built with **ASP.NET Core Razor Pages**, **Entity Framework Core**, and **Identity Scaffolding**.  
The system aims to manage hospital data (hospitals, patients, doctors, medical records) with secure authentication, authorization, and account management.  

This project was developed as an **individual task required by ITI**.  
I built it completely by myself, and it was later reviewed and verified by the supervisor.

The project follows the Database First Approach.
I had an existing SQL Server database, and I used Entity Framework Core Scaffolding to generate the Models and DbContext directly from it.

---

## ERD 
<img width="675" height="483" alt="ERD for hospital" src="https://github.com/user-attachments/assets/2cfcc877-3a17-4685-918c-467114368c42" />

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
