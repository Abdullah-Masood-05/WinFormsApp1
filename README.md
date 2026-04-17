# WinForms Calculator

A feature-rich Windows Forms calculator application built with .NET 6.0 and C#.

## Features

- **Basic Operations**: Addition, subtraction, multiplication, division, and modulo
- **Advanced Functions**: 
  - Factorial
  - Power calculation
  - Logarithm (base 10)
  - Trigonometric functions (sin, cos, tan)
  - Hyperbolic functions (sinh, cosh, tanh)
- **User-Friendly Interface**: Clean button-based interface for easy input
- **Backspace Support**: Remove the last entered digit

## Requirements

- .NET 6.0 or higher
- Windows OS
- Visual Studio 2022 or compatible IDE

## Installation

1. Clone the repository:
```bash
git clone https://github.com/yourusername/WinFormsApp1.git
cd WinFormsApp1
```

2. Open the solution file:
```bash
WinFormsApp1.sln
```

3. Build the project using Visual Studio or the command line:
```bash
dotnet build
```

## Usage

1. Run the application:
```bash
dotnet run
```

2. Use the numeric buttons (0-9) to enter numbers
3. Select an operation (+, -, *, /, %, sin, cos, tan, etc.)
4. Enter the second operand (if applicable)
5. Press the "=" button to calculate the result
6. Use "Backspace" to delete the last digit

## Project Structure

```
├── Form1.cs              # Main calculator form and logic
├── My_Cal.cs             # Designer-generated form components
├── Program.cs            # Application entry point
├── Form1.resx            # Form resources
├── WinFormsApp1.csproj   # Project configuration
└── WinFormsApp1.sln      # Solution file
```

## Technical Details

- **Language**: C#
- **Framework**: .NET 6.0 with Windows Forms
- **Architecture**: Single-form Windows desktop application

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Author

Created as a learning project for Windows Forms development.
