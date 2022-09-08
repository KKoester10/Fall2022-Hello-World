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
    var age = 24L;
    Console.WriteLine(age);
//----------------------------------------------------------------------------------------------------------------------------
// Operators 
// Performs some kind of operation/action on some values
//examples 5 + 13 -> 18

// Assignment Operator:
// Single equal sign '='
// Use this to assign the value of a variable

// Arithmetic:
// addition: +
    var studentCount = 5 + 13;
// subtraction: -
// Multiplication: *
// Divison: /
    var averageClassSize = studentCount / 4f; // 18 / 3 -> 6 || 18 / 4 -> Not a Whole Number (4-5) ||18 / 4f -> 4.5f
    Console.WriteLine(averageClassSize);
// Exponentiation: Math.Pow()
// Modulo: %
// -- Returns the remainder after dividing by a particular number
    var time = 13 % 12; //time has a value of 1 here.

//------------------------------------------------------------------------------------------------------------------------------
// Boolean's
// Boolean is a data type where the only values are 'true' vs 'false' - 'on' vs 'off' - 1 vs 0
    var isSunny = true;

    var isDavis = Instructor == "Davis";// Davis == Davis -> true
    var isdavis = Instructor == "Davis";// Davis == davis -> false 'capilazation matters'

// Equality operators:
// Equality -> '==' & Inequality -> '!='

// comparison operators:
// greater than -> '<'
// greater than or equal -> '<='
// less than -> '>'
// less than or equal -> '>='
    var isGreaterThan = 18 >= 25;// checking is it greater than OR is it equal to?

// Boolean Operators: We have some specific operators defined for actions between two boolean values
// OR -> || ( '|' if you want to run both sides)
// OR truth Operator Table  
// true || false -> true
// false || true -> true
// true || true -> true
// false || false -> false
    var willGoOutSide = isSunny || isDavis;// -> true
// AND -> && ( '&' if you want to run both sides)
// AND truth Operator Table  
// true && false -> false
// false && true -> false
// true && true -> true
// false && false -> false
    var willGoOutSideAgain = isSunny && isDavis;// -> true

// NOT operator -> !
// returns the opposite of a given boolean value
// !true -> false
// !false -> true

// Exclusive OR(XOR) Operator ^
// Only returns true when the left or right are true, false when both are true.
// XOR truth Operator Table  
// true ^ false -> true
// false ^ true -> true
// true ^ true -> false
// false ^ false -> false

// Parsing 
//Trasforming a variable from another type (often a string) into another (often an integer)
var parsedValue = int.Parse("15");// Integer
    Console.WriteLine(parsedValue + 5);

// Incrementing:
// de-incrementing -> i-- & Incrementing -> i++ 


//--------------------------------------------------------------------------------------------------------------------------------

//white space does not matter.
Console.WriteLine("Hello World , My name is Kolton" + " yes theses things matter");
String characterName = "Asbar ";
int oneFive = 15;
//will write characterName 15 times
for (int i = 0; i <= oneFive; i++){
   Console.WriteLine(characterName + i);
}
bool one = true;
bool two = false;
bool three = true;

var questionOne = (one && !two);
Console.WriteLine(questionOne);
var questionTwo = (three || (two && three));
Console.WriteLine(questionTwo);
var questionThree = (!two && (!three && (one || two)) || three);
Console.WriteLine(questionThree);
var questionFour = (one && two && three);
Console.WriteLine(questionFour);
var questionFive = (one||two||three);
Console.WriteLine(questionFive);