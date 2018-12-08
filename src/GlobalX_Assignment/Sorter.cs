using System;
using System.Collections.Generic;


namespace GlobalX_Assignment
{
    public class NameSorter
    {
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
                        output[i] = second;
                        output[i+1] = first;
                        swapped = true;
                    }
                    else if(String.Compare(first.LastName,second.LastName,true) == 0 
                        && String.Compare(first.FirstName, second.FirstName, true)>0)
                    {
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