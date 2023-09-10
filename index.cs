    using System;

    class Program {

        static void Main()
        {

        // In this exercise, you use the IndexOf() method to locate the position of one or more characters string inside a larger string.
        // You use the Substring() method to return the part of the larger string that follows the character positions you specify.
        // You'll also use an overloaded version of the Substring() method to set the length of characters to return after a specified position in a string.

        
        // string message = "Find what is (inside the parentheses)";

        // int openingPosition = message.IndexOf('(');
        // int closingPosition = message.IndexOf(')');

        // openingPosition += 1;

        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length));        

        // string message = "What is the value <span>between the tags</span>?";

        // int openingPosition = message.IndexOf("<span>");
        // int closingPosition = message.IndexOf("</span>");

        // int openingPosition2 = openingPosition += 6;

        // Console.WriteLine(openingPosition);
        // Console.WriteLine(closingPosition);

        // int length = closingPosition - openingPosition;
        // int length2 = closingPosition - openingPosition2;

        // Console.WriteLine(message.Substring(openingPosition, length));
        // Console.WriteLine(message.Substring(openingPosition2, length2));

        // const string openSpan = "<span>";
        // const string closeSpan = "</span>";

        // int openingPosition = message.IndexOf(openSpan);
        // int closingPosition = message.IndexOf(closeSpan);

        // openingPosition += openSpan.Length;
        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length));    


        // * * * *              lastIndexOf()
         
        // string lastIndexMsg = "(What if) I am (only interested) in the last (set of parentheses)?";
        // int openingPosition = lastIndexMsg.LastIndexOf('(');

        // openingPosition += 1;
        // int closingPosition = lastIndexMsg.LastIndexOf(')');
        // int length = closingPosition - openingPosition;
        // Console.WriteLine(lastIndexMsg.Substring(openingPosition, length));

        // * * * *              lastIndexOf()

        // retrieve all instances of substrings within Parenthesis

        // loop over every instance of IndexOf() characters.

        // string message3 = "(What if) there are (more than) one (set of parentheses)?";

        // while (true)
        // {
        //     int openingPosition = message3.IndexOf('(');
        //     if (openingPosition == -1) break;

        //     openingPosition += 1;
        //     int closingPosition = message3.IndexOf(')');
        //     int length = closingPosition - openingPosition;
        //     Console.WriteLine(message3.Substring(openingPosition, length));

        //     // Note the overload of the Substring to return only the remaining 
        //     // unprocessed message3:
        //     message3 = message3.Substring(closingPosition + 1);
        // }

        // loop over every instance of IndexOf() characters.



        // you search for several different symbols, not just a set of parentheses.

        // string message4 = "Help (find) the {opening symbols}";
        // Console.WriteLine($"Searching THIS message4: {message4}");
        // char[] openSymbols = { '[', '{', '(' };
        // int startPosition = 6;
        // int openingPosition = message4.IndexOfAny(openSymbols);
        // Console.WriteLine($"Found WITHOUT using startPosition: {message4.Substring(openingPosition)}");

        // openingPosition = message4.IndexOfAny(openSymbols, startPosition);
        // Console.WriteLine($"Found WITH using startPosition: {message4.Substring(openingPosition)}");


        // different symbols with closing position

        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

        // different symbols with closing position
    

        // you search for several different symbols, not just a set of parentheses.
        }
    }
