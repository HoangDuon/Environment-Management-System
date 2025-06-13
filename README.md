# Environment Monitoring & Management System

This is a desktop-based application developed using C# and Windows Forms in Visual Studio. The software is designed to assist businesses and environmental service providers in managing, monitoring, and calculating key environmental metrics related to **soil, water, air, and emissions**.

### Key Features:
- Manage contracts and order lists
- Notify businesses of order status
- Generate environmental test result tables
- Basic data operations (Add, Edit, Delete)
- AI-powered search integration using VOSK for quick access to records and intelligent filtering
- Statistical dashboard** to visualize environmental data trends and performance

This system supports field technicians and laboratory staff by providing tools to record and update environmental data efficiently and accurately.

## Technologies
- **C#**, .NET Framework (WinForms)
- **Entity Framework** (Data access layer)
- **Vosk** (Offline speech recognition for search and commands)
- **Bcrypt.NET** (User password encryption)
- **Siticone UI** (Modern WinForms interface toolkit)
- **NAudio** (Audio playback and processing)
- **ReportingView** (Generate and display reports

## Getting Started
1. **Clone** this repository to your local machine.
2. **Open** the `.sln` file in **Visual Studio 2022** or later.
3. **Restore NuGet packages** (for Vosk, Entity Framework, Bcrypt, Siticone, etc.).
4. **Download Vosk Vietnamese model manually**:
   - Go to: https://alphacephei.com/vosk/models
   - Download: `vosk-model-small-vi-0.4` (or compatible Vietnamese model)
   - Extract the folder and place it inside the project directory, for example:  
     `YourProjectRoot/EnvironmentManagementSystem/EnvironmentManagementSystem/Models/vosk-model-small-vi-0.4/`
5. **Update your SQL Server connection string** in `App.config`.
6. **Build and run** the project (`F5`).

> ⚠️ **Note:** Make sure the model path in your source code matches the actual folder name and location.

## Demo
Not available online – desktop-only application.

