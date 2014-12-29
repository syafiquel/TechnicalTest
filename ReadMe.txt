

Instruction : (1) Extract the TechnicalTest folder with its entire contents to C:\ drive.
			  (2) Run the TechnicalTest.exe once. See the output.
			  (3) The output files newInput.DAT and output.log must be deleted before running the program again to prevent errors in results.


Information:

(1) This project solution (TechnicalTest) is created by using Microsoft Visual Studio 2013 with .NET Framework 4.5.

(2) There are two (2) programs in this project files:

		(i)  Program that displays the output in console application and save the output in a log file.

		(ii) Program that calculates total fare charges from input file.

(3) This project comprises of three (3) classes:

		(i)   Program.cs - A main program. Runs the other component classes.

		(ii)  displayOutput.cs - Runs the program to write the output in console application and save the output in a logfile. Contains three (3)
							  methods that search and read for specified keyword ($LTNG) in an input file (DataTest.DAT), manipulate the desired
							  strings in the input file, save the file in the specified format and display the output to a console application.
							  
							  Method: seperateKeyword - searches for $LTNG keywords in the TestData.DAT input file.
							  Method: splitString - uses substring to split the raw data into desired strings. Appends it in output.log file
							  Method: consoleOutput - uses the same substring technique to get the strings and applied formatting methods to
													  standardize the output display in console applicationas required.

		(iii) fareCalculator.cs - Calculates the total fare charges by reading the input file and sum all the strings that contained the particular
							   data. The resulting format is standardized into specified format and displayed in console application.

 (4) File organization
	
		(i)   input file: ...\TechnicalTest\TestData.DAT

		(ii)  output file: ...\TechnicalTest\newInput.DAT
						   ...\TechnicalTest\output.log

		(iii) Program.cs:   ...\TechnicalTest\Program.cs

		(iv)  displayOutput.cs  ...\TechnicalTest\displayOutput.cs

		(v)   fareCalculator.cs  ...\TechnicalTest\fareCalculator.cs

		(vi)  TechnicalTest.exe  ...\TechnicalTest\TechnicalTest.exe


  (5) Source Control

	  A GitHub repository is created for this project in accessible at www.github.com/syafiquel/TechnicalTest
		