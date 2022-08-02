// The Liskov Substitution Principle (LSP) states that an instance of a child class
// must replace an instance of the parent class without affecting the results
// that we would get from an instance of the base class itself.
// This will ensure the class and ultimately the whole application is very robust and easy to maintain and expand,
// if required.

using SolidPrinciples;

var filePath = @"D:\Demos\PerformanceAndBestPractices\BestPracticesDemos\SolidPrinciples\Sample.txt";

#region Liskov Substitution Not Compliant

AccessDataFile accessDataFile = new AdminDataFileUser();
accessDataFile.FilePath = filePath;
accessDataFile.ReadFile();
accessDataFile.WriteFile();

AccessDataFile accessDataFileR = new RegularDataFileUser();
accessDataFileR.FilePath = filePath;
accessDataFileR.ReadFile();
accessDataFileR.WriteFile();  // Throws exception

#endregion

#region Liskov Substitution Compliant

IFileReader fileReader = new AdminDataFileUserFixed();
fileReader.ReadFile(filePath);

IFileWriter fileWriter = new AdminDataFileUserFixed();
fileWriter.WriteFile(filePath);

IFileReader fileReaderR = new RegularDataFileUserFixed();
fileReaderR.ReadFile(filePath);

#endregion