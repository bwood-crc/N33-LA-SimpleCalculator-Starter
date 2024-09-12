
*Read me*
1- We changed ConvertInputToNumeric to a static method int the InputConverter class.
2- we fixed the issues related to the usage in the main program of the ConvertInputToNumeric method, as well as the InputConverter class.
3- we put a temporary line that wrote on the command prompt a string and the answer after that string to test if everything was working so far.
4- we moved the CalcUtilities class from SimpleCalculator to CalcLibrary.
5- we formatted the string to display the result to be the same as the one in the document and using a decimal precision of 2.
6- we built the ConvertInputToNumeric method. 
7- we created the switch cases in the Calculate method for the operations to accept their written or symbolic forms.
8- we modified the ConvertInputToNumeric method to loop if the user did not enter a correct number (numeric form) and catch exceptions.
9- we fixed syncing issues between our two projects to have one functional project.
10-we fixed the implementation of the Calculate method in our main program by making the method static in the class CalcUtilities.
11 - we fixed issues in our toString to ask the user for an operation to perform and added a method in the InputConverter class named OperationConverter to be able to convert the string passing the operation into the operation itself.
12- we added a 5th operation (power) in CalcLibrary and a case for it, and added switch cases to the InputConverter class in the OperationConverter method. we also modified the string in the main that asked which type of operation the user wished to perform to add the "power" option.
13- we modified the whole CalcUtilities class to reformat the cases as well as add exception handling to the class.
14- We modified the catching of exceptions in the InputConverter class in the method ConvertInputToNumeric, as well as the default case in the OperationConverter method. Finally we changed the string to display the result on the console once again.
15-we added a few lines of code in the main program to check if a division by zero was happening and if so to display 0 as the result instead of the infinity sign.
16- we removed the CalculatorEngine class as we were not using it.
17- we made it so that the tests were using the actual classes and their name instead of creating objects of the classes to use in the tests.
18- we merged to fixed syncing issues
19- we re-did the InputConverter method so that it does not interact with the user and instead added the user interaction in the main program.
20- we deleted the call to a method and then merged to fix syncing issues again.
21- we created the IsValidOperator Boolean method and implemented it to the main program.
22- we fixed and added tests to the CalculatorEngineTest class.
23- we added a try block in the Calculate method in CalcUtilities and moved another try block elsewhere to make everything work.
24- then we added and fixed multiple test methods in the test class to be able to test the methods used in the entire program.

