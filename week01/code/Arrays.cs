public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Plan: 
        // 1. Create an array of n'length'.
        // 2. Use a loop to populate the array.(fist element is 'number', each subsequent element is the previous element + 'number')
        // 3. Return the array.

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result; // replace this return statement with your own
    }
    // DONE

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Plan:
        // 1.use the modulo operator:  amount % data.Count
        // 2. If the effective rotation is 0, do nothing.
        // 3. Use list slicing to rearrange the data.
        // 4. Use the last amount elements using GetRange() and take the rest of the list up to the last amount elements.
        // 5. combine the two slices
        // 6. Update the original list with the rearranged data.

        int rotation = amount % data.Count;
        if (rotation == 0) return;

        List<int> end = data.GetRange(data.Count - rotation, rotation);
        List<int> start = data.GetRange(0, data.Count - rotation);

        data.Clear();
        data.AddRange(end);
        data.AddRange(start);
         
    }
}
// DONE
