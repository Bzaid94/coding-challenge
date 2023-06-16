# Phone Pad Converter

This project is a C# implementation of a converter that transforms number sequences, based on an old phone pad, into text. Each button press corresponds to a letter, and multiple presses cycle through the options on each button. A pause is necessary to type two characters from the same button.

## Using the Phone Pad Converter

To use the converter, run the application and follow the prompt to input a sequence of numbers. Each number corresponds to a letter or a set of letters on the old phone pad. Pressing a number multiple times cycles through the letters. You must pause to type two characters from the same button.

The sequence always ends with the symbol '#'. If you want to stop testing, type 'exit' and press Enter.

For example:
```csharp
Enter the sequence of numbers (or 'exit' to quit)
4433555 555666#
The result is HELLO

Or

Enter the sequence of numbers (or 'exit' to quit)
8 88777444666*664#
The result is TURING

```

## Error Handling

If an illegal character is input, the program will throw an `ArgumentException` and print a message indicating the issue. The program will then allow you to try again.

## About the Implementation

This project uses the principles of Object-Oriented Programming (OOP) to separate responsibilities into different classes. The `PhonePad` class holds the main logic for the conversion, while the `Button` class represents each button on the phone pad.

## Contributing

Contributions are welcome. Please open an issue first to discuss what you would like to change.
