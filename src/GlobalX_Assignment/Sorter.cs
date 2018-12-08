using System;
using System.Collections.Generic;


namespace GlobalX_Assignment
{
    public class NameSorter
    {

        // Sort()
        // A static class to sort a list of names
        // Reason for Bubble Sort:
        // > Highly readable
        // > Easy to implement as there is no performance specification.
        public static List<Name> Sort(List<Name> input)
        {
            List<Name> output = input;
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < (input.Count-1); i++)
                {
                    Name first = output[i];
                    Name second = output[i+1];
                    if(String.Compare(first.LastName,second.LastName,true) > 0)
                    {
                        // if Last name of second checked entry is supposed to be before first checked entry.
                        output[i] = second;
                        output[i+1] = first;
                        swapped = true;
                    }
                    else if(String.Compare(first.LastName,second.LastName,true) == 0 
                        && String.Compare(first.FirstName, second.FirstName, true)>0)
                    {
                        // if Last name of second checked entry is the same as first checked entry,
                        // also checks the first name of the entry
                        output[i] = second;
                        output[i+1] = first;
                        swapped = true;
                    }
                }
            } while (swapped);
            return output;
        }
    }
}