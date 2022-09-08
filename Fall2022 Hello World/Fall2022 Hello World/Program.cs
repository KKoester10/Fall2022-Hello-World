//what is this stuff?
//what is a 'console' application?
//what's with the fancy coloring? 

//Hello World Workshop
Console.WriteLine("Hello, World!");
// Variables and Objects

// Variable Declaration
// Variable Declaration is stating that we have a variable and giving it an associated name 
// if you are just doing variable declaration, you must state the variable type first

// variableType variableName;
    String Instructor;

// Variable Assignment
// Variable assignment is giving a variable a value (of the appropriate type) for us to reference later

//variableName = value;
    Instructor = "Gavin";
// Variable Reassignment
    Instructor = "Davis";

// All together now!
// if we use 'var', C# will understand that age is and integer based on the value from the right of the equal sign.

// var/variableType variableName = value; 
    var age = 24;
    Console.WriteLine(age);
//----------------------------------------------------------------------------------------------------------------------------
// Operators 
// Performs some kind of operation/action on some values
//examples 5 + 13 -> 18

// Assignment Operator
// Single equal sign
// Use this to assign the value of a variable

// Arithmetic:
// addition: +
    var studentCount = 5 + 13;
// subtraction: -
// Multiplication: *
// Divison: /
    var averageClassSize = studentCount / 4f; // 18 / 3 -> 6 || 18 / 4 -> Not a Whole Number (4-5) ||18 / 4f -> 4.5f
    Console.WriteLine(averageClassSize);
// Exponentiation: ^
// Modulo: %
// -- Returns the remainder after dividing by a particular number
    var time = 13 % 12; //time has a value of 1 here.

// Equality operators:
// Equality -> '==' & Inequality -> '!='

// comparison operators:
// greater than -> '<'
// greater than or equal -> '<='
// less than -> '>'
// less than or equal -> '>='

// Incrementing:
// de-incrementing -> i-- & Incrementing -> i++ 

// Logical:
// AND -> &&
// OR -> ||



//white space does not matter.
Console.WriteLine("Hello World , My name is Kolton" + " yes theses things matter");
String characterName = "Asbar ";
int oneFive = 15;
//will write characterName 15 times
for (int i = 0; i <= oneFive; i++){
   Console.WriteLine(characterName + i);
}
