using System;
using System.Collections.Generic;

namespace GlobalX_Assignment
{

    // The Name class
    // Processes a raw string to Name instance
    // Splits the name into first name and last name
    public class Name
    {
        private string _firstName;
        private string _lastName;

        public Name(string fullName)
        {
            // specify delimiter and output variable
            Char[] delimiter = new Char[] {' '};
            String[] split = null;
            // According to specification, last name + (max. 3) first name
            const int count = 4;
            split = fullName.Split(delimiter, count);
            if(split.Length < 2)
            {
                // throw exception if input doesn't have first name and last name
                throw new ArgumentException("Not enough names parsed");
            }
            // initiate initial first name string
            _firstName = "";
            // A generic way to append over the first name
            for(int i = 0; i < (split.Length-1);i++){
                _firstName = String.Concat(_firstName,split[i]," ");
            }
            // trim the ending space.
            _firstName = _firstName.Trim();
            _lastName = split[split.Length-1];
        }

        // Getter for FirstName
        public string FirstName
        {
            get{return this._firstName;}
        }

        // Getter for LastName
        public string LastName
        {
            get{return this._lastName;}
        }

        // BatchConvert()
        // Convert a list of string into a list of Name class
        public static List<Name> BatchConvert(List<string> input)
        {
            List<Name> output = new List<Name>();
            foreach (var item in input)
            {
                output.Add(new Name(item));
            }
            return output;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                return _firstName == ((Name) obj).FirstName && _lastName == ((Name) obj).LastName;
            }
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        // override object.ToString
        public override string ToString()
        {
            return String.Concat(_firstName," ",_lastName);
        }

    }
}