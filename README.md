<h1 align="center">Basic Calculator 📱</h1>
<h2 align="center">Project description</h2>

This project is a <b>basic calculator program</b> written in C#. It allows users to perform basic mathematical operations such as addition, 
subtraction, multiplication, division, modulo, and exponentiation. The program prompts the user to input two numbers and a mathematical operator and then displays the result of the operation. 
It includes robust input validation to ensure the entered values are valid numbers and that the operator used is one of the allowed operations.<br>
![C__Users_Właściciel_source_repos_Calculator_Calculator_bin_Debug_net8 0_Calculator exe 2025-03-06 11-18-28](https://github.com/user-attachments/assets/5a60e1e8-f91e-4916-bfb4-f2c64366eeff)


**Key Features**
* <b>Input Validation:</b> Ensures that the user enters valid numbers and mathematical operators.
* <b>Supported Operations:</b> Addition (+), Subtraction (-), Multiplication (*), Division (/), Modulo (%), and Exponentiation (^).
* <b>Handling Division by Zero:</b> Safeguards against division by zero, notifying the user if they attempt this operation.
* <b>Option to Quit:</b> After each calculation, the user can either quit the program or continue by inputting new values.

**Problems Solved During Development**
1. <b>Input Validation:</b>
* One of the key challenges in this project was ensuring that the user input was correctly handled.
      Initially, the program could crash if invalid data was entered (such as letters or special characters when numbers were expected)
  * <b>Solution:</b> Implemented a method to ensure only valid numbers are accepted, using double.TryParse(). This prevents the program from crashing when invalid inputs are entered and instead prompts the user to try again.
2. <b>Handling Invalid Mathematical Operators:</b>
* Early versions allowed the user to input any string, which would cause errors if the operator was not recognized.
  * <b>Solution:</b> Added a validation mechanism that checks whether the entered operator is part of a predefined set of allowed operators (+, -, *, /, %, ^). If the input is invalid, the user is prompted to re-enter a valid operator.
3. <b>Division by Zero:</b>
* Division by zero is a common issue that needs to be handled gracefully in mathematical calculations. Without proper checks, this can lead to runtime exceptions.
  * <b>Solution:</b> Included a specific check in the code to detect division by zero. If detected, a custom message informs the user that division by zero is not allowed.
4. <b>Exponentiation Edge Case:</b>
* Exponentiation of any number raised to the power of zero should always return 1, but ensuring this is calculated correctly required an additional edge case check.
  * <b>Solution:</b> Implemented a condition to handle cases where the exponent is zero and return 1 directly without performing unnecessary calculations.
5. <b>Program Flow Control:</b>
* Allowing the user to quit or continue based on their input posed a challenge in managing program flow.
  * <b>Solution:</b> Added a simple mechanism where the user can type q to quit the program, or press Enter to continue, maintaining a user-friendly interface.

<h2 align="center">Conclusion</h2>
By solving the above issues, this project demonstrates a clean, simple, and effective calculator tool that is robust against invalid inputs and exceptions. It also provides a good user experience by continuously validating input and handling special cases such as division by zero and exponentiation.

This calculator project serves as a solid foundation for further development, such as adding additional mathematical functions, support for more complex expressions, or improving the user interface.
