Module Program
    Sub Main()
        ' Declare variables
        Dim num1 As Double
        Dim num2 As Double
        Dim sum As Double

        ' Get input from user
        Console.Write("Enter the first number: ")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.Write("Enter the second number: ")
        num2 = Convert.ToDouble(Console.ReadLine())

        ' Add the numbers
        sum = num1 + num2

        ' Display the result
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}")

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
Add VB.NET code to add two numbers"
