
// File.Copy(path of a file to be copy, path of a distination to keep copied file)

File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

//File.Delete(path of a file to delete)

File.Delete(@"c:\temp\myfile.jpg");

//File.Exist(path of a file to check file exist or not);

if (File.Exists(@"c:\temp\myfile.jpg"))
{
    //do something
}

//File.ReadAllText(path of a file to read) and return a string;
var content = File.ReadAllText(@"c:\temp\myfile.jpg");


//FileInfo

var fileInfo = new FileInfo(@"c:\temp\myfile.jpg");
fileInfo.CopyTo("path");
fileInfo.Delete();
if (fileInfo.Exists)
{
    //
}