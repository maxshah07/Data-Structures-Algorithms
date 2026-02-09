//Value Types are data types that hold their value directly in memory. When you assign a value type to another variable, it creates a copy of the value. This means that changes to one variable do not affect the other variable.

using Red_Value_Types;

Console.WriteLine("Value Types Example:");

int a = 5;
int b = 6;

Console.WriteLine($"\nThe value of {nameof(a)} is {a}"); //5
Console.WriteLine($"The value of {nameof(b)} is {b}"); //6

a = b;

Console.WriteLine($"\nThe value of {nameof(a)} is {a}"); //6
Console.WriteLine($"The value of {nameof(b)} is {b}"); //6

b = 10;

Console.WriteLine($"\nThe value of {nameof(a)} is {a}"); //6
Console.WriteLine($"The value of {nameof(b)} is {b}"); //10

//Reference Types, on the other hand, hold a reference to the actual data in memory. When you assign a reference type to another variable, it creates a reference to the same data. This means that changes to one variable will affect the other variable since they both point to the same data.

Console.WriteLine("Reference Types Example:");
ReferenceTypeClass refA = new ReferenceTypeClass { value = 5 };
ReferenceTypeClass refB = new ReferenceTypeClass { value = 6 };

Console.WriteLine($"\nThe value of {nameof(refA)}.value is {refA.value}"); //5
Console.WriteLine($"The value of {nameof(refB)}.value is {refB.value}"); //6

refA = refB;

Console.WriteLine($"\nThe value of {nameof(refA)}.value is {refA.value}"); //6
Console.WriteLine($"The value of {nameof(refB)}.value is {refB.value}"); //6

refB.value = 10;

Console.WriteLine($"\nThe value of {nameof(refA)}.value is {refA.value}"); //10
Console.WriteLine($"The value of {nameof(refB)}.value is {refB.value}"); //10