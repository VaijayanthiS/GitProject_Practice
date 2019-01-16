using System;
					
public class Program
{

  public static void Main()
   {
   
           string testValue = "Hi! Welcome to C#.This program is for practice purpose";

           Console.WriteLine(testValue.Contains("practice"));

           Console.WriteLine(testValue.Contains("practical"));

       }
   }

   public static class StringExtensions
   {
       public static bool Contains(this string str, params string[] values)
       {
           if (!string.IsNullOrEmpty(str) || values.Length > 0)
           {
               foreach (string value in values)
               {
                   if(str.Contains(value))
                       return true;
               }
           }

           return false;
       }

}
   
