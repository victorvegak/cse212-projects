public static class MysteryStack1 {

    /// <summary>
    /// This method reverses the input text using a stack.
    /// 
    /// Example:
    /// input: "racecar" -> output: "racecar"
    /// input: "stressed" -> output: "desserts"
    /// input: "a nut for a jar of tuna" -> output: "anutforajaroftuna"
    /// </summary>
    /// <param name="text">The Input string to be reversed</param>
    /// <returns>The reversed string</returns>
    public static string Run(string text) {
        var stack = new Stack<char>();// Initialize a stack to hold the characters
        foreach (var letter in text)
            stack.Push(letter);// Push each character of the string into the stack

        var result = "";// Initialize the result string
        while (stack.Count > 0)
            result += stack.Pop(); //  Pop characters from the stack and build the reversed string 

        return result; // Return the reversed string
    }
}