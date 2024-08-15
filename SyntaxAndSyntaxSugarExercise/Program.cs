namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer1 = 4;
            var answer2 = 9;
            //var response = "";
            
            //First Version w/ If Else (Commented Out Below):
            //_______________________________________________
            
            //if (answer1 < answer2)
            //{
                //response = answer1 + $" is less than {answer2}.";
            //}
            //else
            //{
                //response = answer1 + $" is greater than or equal to {answer2}.";
            //}
            
            //Console.WriteLine($"{response}");
            
            
            
            //Second Version w/ Ternary (Below):
            //_________________________________
            
            //Condition, TrueScope, FalseScope
            var response = (answer1 < answer2)
                ? answer1 + $" is less than {answer2}."
                : answer1 + $" is greater than or equal to {answer2}.";
            
            Console.WriteLine(response);

        }
    }
}
