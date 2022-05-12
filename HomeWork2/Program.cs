//Capture a users age from console.
//Inform them of age in 25 years
//Inform them of age 25 years ago.
//Use natural language in result.


Console.Write("How old are you? ");
string? ageText = Console.ReadLine();

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"You said you are {age} years old. In 25 years you will be {age + 25}\n25 years ago you were {age - 25}.");
