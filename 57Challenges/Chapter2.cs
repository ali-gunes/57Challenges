namespace _57Challenges;

public class Chapter2
{
    #region E1:Saying Hello
        // Saying Hello
        // The “Hello, World” program is the first program you learn
        //     to write in many languages, but it doesn’t involve any input.
        //     So create a program that prompts for your name and prints
        // a greeting using your name.
        //    
        //     Example Output
        //     What is your name? Brian
        //     Hello, Brian, nice to meet you!
        //    
        // Constraint
        // • Keep the input, string concatenation, and output separate.
        //    
        //     Challenges
        // • Write a new version of the program without using any
        //     variables.

        public void SayingHello()
        {
            // To avoid using a variable we can prompt the name inside the console.writeline.
            // WriteLine method needs to evaulate everyting in the parantheses to output anything so its gonna
            // call ReadLine method and prompt user before anything.
            Console.Write("What is your name? ");
            Console.WriteLine($"Hello, {Console.ReadLine()}, nice to meet you!");
        }
    #endregion
    
    #region E2:CountingCharacters
        // Create a program that prompts for an input string and dis-
        // plays output that shows the input string and the number of
        //     characters the string contains.
        //     Example Output
        //     What is the input string? Homer
        //     Homer has 5 characters.
        
        // Constraints
        // • Be sure the output contains the original string.
        // • Use a single output statement to construct the output.
        // • Use a built-in function of the programming language to
        // determine the length of the string.
        
        // Challenges
        // • If the user enters nothing, state that the user must enter
        // something into the program.
        // • Implement this program using a graphical user interface
        //     and update the character counter every time a key is
        // pressed. If your language doesn’t have a particularly
        // friendly GUI library, try doing this exercise with HTML
        //     and JavaScript instead.

        public void CountingCharacters()
        {
            Console.Write("What is the input string? ");
            string? input = Console.ReadLine();
            if (input!.Length == 0)
            {
                Console.WriteLine("No input");
            }
            else
            {
                Console.WriteLine($"{input} has {input.Length} characters.");
            }
        }
    #endregion
    
    #region E3:PrintingQuotes
        // Quotation marks are often used to denote the start and end
        //     of a string. But sometimes we need to print out the quotation
        // marks themselves by using escape characters.
        //     Create a program that prompts for a quote and an author.
        //     Display the quotation and author as shown in the example
        // output.
        
        //     Example Output
        // What is the quote? These aren't the droids you're looking for.
        // Who said it? Obi-Wan Kenobi
        // Obi-Wan Kenobi says, "These aren't the droids
        // you're looking for."
        
        // Constraints
        // • Use a single output statement to produce this output,
        // using appropriate string-escaping techniques for quotes.
        // • If your language supports string interpolation or string
        //     substitution, don’t use it for this exercise. Use string
        //     concatenation instead.
        
        // Challenge
        // • In Chapter 7, Data Structures, on page 63, you’ll practice
        // working with lists of data. Modify this program so that
        //     instead of prompting for quotes from the user, you cre-
        // ate a structure that holds quotes and their associated
        //     attributions and then display all of the quotes using the
        //     format in the example. An array of maps would be a
        // good choice.

        public void PrintingQuotes()
        {
            Console.WriteLine("The quote is:");
            string? quote = Console.ReadLine();
            
            Console.WriteLine("Who said it?");
            string? author = Console.ReadLine();

            Console.WriteLine($"{author} says, \"{quote}\"");
        }
    #endregion
    
    #region E4:MadLib
        // Mad libs are a simple game where you create a story tem-
        // plate with blanks for words. You, or another player, then
        //     construct a list of words and place them into the story, cre-
        // ating an often silly or funny story as a result.
        //     Create a simple mad-lib program that prompts for a noun,
        //     a verb, an adverb, and an adjective and injects those into a
        //     story that you create.
        //     Example Output
        // Enter a noun: dog
        //     Enter a verb: walk
        //     Enter an adjective: blue
        //     Enter an adverb: quickly
        //     Do you walk your blue dog quickly? That's hilarious!
        // Constraints
        // • Use a single output statement for this program.
        // • If your language supports string interpolation or string
        //     substitution, use it to build up the output.
        //     Challenges
        // • Add more inputs to the program to expand the story.
        // • Implement a branching story, where the answers to
        //     questions determine how the story is constructed. You’ll
        //     explore this concept more in the problems in Chapter
        // 4, Making Decisions, on page 29.

        public void MadLib()
        {
            Console.Write("Enter a noun: ");
            string? noun = Console.ReadLine();
            
            Console.Write("Enter a verb: ");
            string? verb = Console.ReadLine();
            
            Console.Write("Enter an adjective: ");
            string? adjective = Console.ReadLine();
            
            Console.Write("Enter adverb: ");
            string? adverb = Console.ReadLine();
            
            Console.WriteLine($"Do they {verb} his {adjective} {noun} {adverb}. Thats stupid!");
        }
    #endregion
}