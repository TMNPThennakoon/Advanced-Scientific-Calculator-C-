# 🧮 Advanced Scientific Calculator

<div align="center">

![Calculator Preview](https://img.shields.io/badge/Calculator-Scientific-blue?style=for-the-badge)
![.NET](https://img.shields.io/badge/.NET-4.8-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=c-sharp)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

**A comprehensive Windows desktop application that combines essential calculation tools with scientific functions, unit conversions, and temperature conversions—all in one elegant, user-friendly interface.**

[Features](#-key-features) • [Installation](#-installation) • [Usage](#-usage) • [Screenshots](#-screenshots) • [Technology](#-technology-stack)

</div>

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Key Features](#-key-features)
- [Screenshots](#-screenshots)
- [Technology Stack](#-technology-stack)
- [Installation](#-installation)
- [Usage](#-usage)
- [Project Structure](#-project-structure)
- [Development](#-development)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 Overview

The **Advanced Scientific Calculator** is a feature-rich Windows desktop application designed to be your all-in-one mathematical companion. Whether you're a student tackling complex equations, an engineer performing quick calculations, or someone who needs reliable unit conversions, this application delivers precision and ease of use in a beautifully designed interface.

Built with **C#** and **.NET WinForms**, this project showcases modern software development practices including modular architecture, clean code principles, and intuitive user experience design. The application seamlessly integrates multiple calculation modes, making it a versatile tool for both everyday use and professional applications.

### ✨ What Makes It Special?

- 🎨 **Polished User Interface** - Clean, modern design with smooth interactions
- 🚀 **Lightning-Fast Performance** - Optimized calculations with instant results
- 🛡️ **Robust Error Handling** - Graceful handling of edge cases and invalid inputs
- 📦 **Modular Architecture** - Well-organized codebase for easy maintenance and extension
- 🎯 **Multi-Purpose Tool** - Standard, scientific, and conversion capabilities in one app

---

## ✨ Key Features

### 🧮 Standard Calculator
Experience the fundamentals of calculation with a clean, intuitive interface:
- **Basic Operations**: Addition, subtraction, multiplication, and division
- **Advanced Functions**: Percentage calculations, power operations (x^y)
- **Smart Controls**: Backspace for corrections, Clear (C) and Clear Entry (CE) options
- **Real-time Display**: Shows current operation and final results with full expression history
- **Error Prevention**: Division by zero protection and input validation

### 🔬 Scientific Calculator
Unlock advanced mathematical capabilities:
- **Trigonometric Functions**: Sin, Cos, Tan (with degree-to-radian conversion)
- **Logarithmic Functions**: Natural logarithm (ln) and base-10 logarithm (log)
- **Exponential Functions**: e^x (exponential) and power operations
- **Root Operations**: Square root calculations
- **Special Functions**: Factorial, reciprocal (1/x), and sign change (±)
- **Precision**: High-accuracy floating-point calculations

### 📏 Unit Converter
Effortlessly convert between different measurement units:
- **Length & Distance**: Inches, Centimeters, Feet, Meters, Kilometers
- **Smart Conversion**: Automatic unit filtering to prevent invalid conversions
- **Real-time Results**: Instant conversion with precision formatting
- **User-Friendly**: Dropdown selection with clear input/output labels
- **Validation**: Input error handling with helpful user messages

### 🌡️ Temperature Converter
Quick and accurate temperature conversions:
- **Multiple Scales**: Celsius, Fahrenheit, and Kelvin support
- **Bidirectional Conversion**: Convert from Celsius to Fahrenheit and vice versa
- **Instant Results**: Real-time conversion with formatted output
- **Simple Interface**: Checkbox-based selection for intuitive operation
- **Precise Display**: Formatted results with proper unit symbols (°C, °F)

### 🎨 User Experience Enhancements
- **Splash Screen**: Professional 3-second splash screen on application launch
- **Error Messages**: Clear, user-friendly error notifications
- **Input Validation**: Prevents calculation errors and unexpected crashes
- **Smooth Interactions**: Responsive button clicks and visual feedback
- **Menu Navigation**: Easy access to converter tools via menu bar

---

## 📸 Screenshots

### Main Calculator Interface with Scientific Functions
![main-calculator](https://github.com/user-attachments/assets/580bb56c-3953-4a02-87f2-1eacbb48b0fa)
*The main calculator interface featuring both standard and scientific functions*

### Unit Converter
![unit-converter](https://github.com/user-attachments/assets/6895b8dd-5a46-4210-977c-fb19e3d04fa5)
*Convert between different length and distance units with ease*

### Temperature Converter
![temperature-converter](https://github.com/user-attachments/assets/389ccf94-0ff0-4039-9158-2339e2c6e916)
*Quick temperature conversions between Celsius and Fahrenheit*


> **Note**: Screenshots should be added to the `screenshots/` directory. Replace the placeholder paths above with your actual screenshot files.

---

## 🛠️ Technology Stack

### Core Technologies
- **Language**: C# (C-Sharp)
- **Framework**: .NET Framework 4.8
- **UI Framework**: Windows Forms (WinForms)
- **IDE**: Visual Studio
- **Platform**: Windows Desktop Application

### Development Tools
- **Version Control**: Git
- **Project Management**: Visual Studio Solution (.sln)
- **Resource Management**: Embedded Resources (.resx)

### Architecture Highlights
- **Modular Design**: Separate forms for each feature module
- **Resource Files**: Centralized UI resource management
- **Clean Code**: Well-structured classes with reusable methods
- **Error Handling**: Try-catch blocks for robust operation
- **State Management**: Proper variable tracking for calculation flow

---

## 📥 Installation

### Prerequisites
- **Windows OS**: Windows 7 or later
- **.NET Framework**: Version 4.8 or higher
- **Visual Studio** (for development): 2019 or later (optional)

### Quick Start

1. **Clone the Repository**
   ```bash
   git clone https://github.com/TMNPThennakoon/Advanced-Scientific-Calculator-C-.git
   cd Advanced-Scientific-Calculator-C-
   ```

2. **Navigate to Project Directory**
   ```bash
   cd "CalculatorApp program file"
   ```

3. **Open in Visual Studio**
   - Double-click `CalculatorApp.sln` to open in Visual Studio
   - Or open Visual Studio and navigate to File → Open → Project/Solution

4. **Build the Project**
   - Press `Ctrl + Shift + B` or go to Build → Build Solution
   - The executable will be generated in `bin\Debug\` or `bin\Release\`

5. **Run the Application**
   - Press `F5` to run in debug mode
   - Or navigate to `bin\Debug\CalculatorApp.exe` and double-click

### Running the Executable
If you have a pre-built executable:
1. Navigate to `CalculatorApp program file\CalculatorApp\bin\Debug\`
2. Double-click `CalculatorApp.exe`
3. Enjoy the calculator!

---

## 🚀 Usage

### Standard Calculator Operations

1. **Basic Calculation**
   - Enter your first number
   - Click an operator (+, -, ×, ÷)
   - Enter your second number
   - Click `=` to see the result

2. **Percentage**
   - Enter a number
   - Click `%` to convert to percentage (divide by 100)

3. **Power Operation**
   - Enter the base number
   - Click `^` (power button)
   - Enter the exponent
   - Click `=` for the result

### Scientific Calculator Operations

1. **Trigonometric Functions**
   - Enter an angle in degrees
   - Click `Sin`, `Cos`, or `Tan` for the result

2. **Logarithmic Functions**
   - Enter a positive number
   - Click `ln` for natural logarithm or `log` for base-10 logarithm

3. **Other Functions**
   - **Square Root**: Enter number → Click `√`
   - **Factorial**: Enter integer → Click `n!`
   - **Reciprocal**: Enter number → Click `1/x`
   - **Exponential**: Enter number → Click `e^x`

### Unit Converter

1. **Select Source Unit**
   - Choose the unit you want to convert from (dropdown)

2. **Enter Value**
   - Type the numeric value in the input field

3. **Select Target Unit**
   - Choose the unit you want to convert to (automatically filtered)

4. **Convert**
   - Click the convert button to see the result

### Temperature Converter

1. **Enter Temperature**
   - Type the temperature value in the input field

2. **Select Conversion Type**
   - Check "To Fahrenheit" for Celsius → Fahrenheit
   - Check "To Celsius" for Fahrenheit → Celsius

3. **Convert**
   - Click the convert button to see the formatted result

---

## 📁 Project Structure

```
Advanced-Scientific-Calculator-C-
│
├── CalculatorApp program file/
│   ├── CalculatorApp.sln          # Visual Studio solution file
│   └── CalculatorApp/
│       ├── Form1.cs                # Main calculator form (Standard + Scientific)
│       ├── Form1.Designer.cs       # UI design for Form1
│       ├── Form2.cs                # Splash screen form
│       ├── Form2.Designer.cs       # UI design for Form2
│       ├── Form3.cs                # Unit converter form
│       ├── Form3.Designer.cs       # UI design for Form3
│       ├── Form4.cs                # Temperature converter form
│       ├── Form4.Designer.cs       # UI design for Form4
│       ├── Program.cs              # Application entry point
│       ├── CalculatorApp.csproj    # Project configuration
│       ├── App.config              # Application configuration
│       │
│       ├── Properties/
│       │   ├── Resources.resx      # Embedded resources
│       │   ├── Settings.settings   # Application settings
│       │   └── AssemblyInfo.cs     # Assembly metadata
│       │
│       ├── Resources/
│       │   └── [Image files]       # Application images and icons
│       │
│       └── bin/
│           ├── Debug/              # Debug build output
│           └── Release/            # Release build output
│
├── README.md                       # This file
└── .gitignore                      # Git ignore rules
```

---

## 💻 Development

### Building from Source

1. **Open the Solution**
   ```bash
   # Navigate to project directory
   cd "CalculatorApp program file"
   # Open CalculatorApp.sln in Visual Studio
   ```

2. **Restore Dependencies**
   - Visual Studio will automatically restore NuGet packages (if any)

3. **Build Configuration**
   - **Debug**: For development and testing
   - **Release**: For optimized production builds

4. **Compile**
   - Use `Build → Build Solution` or `Ctrl + Shift + B`

### Code Structure

- **Form1**: Main calculator logic with standard and scientific operations
- **Form2**: Splash screen with 3-second display timer
- **Form3**: Unit converter with length/distance conversions
- **Form4**: Temperature converter with Celsius/Fahrenheit support
- **Program.cs**: Application entry point with splash screen initialization

### Key Implementation Details

- **State Management**: Uses boolean flags and variables to track operation state
- **Error Handling**: Comprehensive try-catch blocks for user input validation
- **UI Threading**: Proper use of `Application.DoEvents()` for splash screen rendering
- **Resource Management**: Embedded resources for images and UI elements

---

## 🤝 Contributing

Contributions are welcome! If you'd like to contribute to this project:

1. **Fork the Repository**
   - Click the "Fork" button on GitHub

2. **Create a Feature Branch**
   ```bash
   git checkout -b feature/amazing-feature
   ```

3. **Make Your Changes**
   - Follow the existing code style
   - Add comments for complex logic
   - Test thoroughly

4. **Commit Your Changes**
   ```bash
   git commit -m "Add amazing feature"
   ```

5. **Push to Your Branch**
   ```bash
   git push origin feature/amazing-feature
   ```

6. **Open a Pull Request**
   - Describe your changes clearly
   - Reference any related issues

### Contribution Guidelines
- Write clean, readable code
- Add error handling for edge cases
- Update documentation if needed
- Test your changes before submitting

---

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

```
MIT License

Copyright (c) 2025 TMNPThennakoon

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## 👤 Author

**TMNPThennakoon**

- GitHub: [@TMNPThennakoon](https://github.com/TMNPThennakoon)
- Repository: [Advanced-Scientific-Calculator-C-](https://github.com/TMNPThennakoon/Advanced-Scientific-Calculator-C-)

---

## 🙏 Acknowledgments

- Built with Visual Studio and .NET Framework
- Inspired by the need for a comprehensive desktop calculator solution
- Thanks to the open-source community for inspiration and support

---

## 📊 Project Status

![Status](https://img.shields.io/badge/Status-Active-success?style=flat-square)
![Version](https://img.shields.io/badge/Version-1.0.0-blue?style=flat-square)

**Current Status**: ✅ Active Development

---

<div align="center">

**⭐ If you find this project helpful, please consider giving it a star! ⭐**

Made with ❤️ using C# and .NET WinForms

</div>
