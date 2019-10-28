namespace CallerInfoAttributes
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerMemberName());
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerFilePath());
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerLineNumber());
        }
    }
}
