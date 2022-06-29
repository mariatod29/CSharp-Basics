using System;

class Replacing
{
    public void ReplaceSubstring()
    {
        string doc = "Hello, some@gmail.com, " +
            "you have been using some@gmail.com in your registration.";
        string fixedDoc = doc.Replace("some@gmail.com", "john@smith.com");
        Console.WriteLine(fixedDoc);
    }
}