using System;
using System.Collections.Generic;

namespace GlobalX_Assignment
{
    public class Name
    {
        private string _firstName;
        private string _lastName;

        public Name(string fullName)
        {
            Char[] delimiter = new Char[] {' '};
            String[] split = null;
            split = fullName.Split(delimiter,4);
            if(split.Length < 2)
            {
                throw new ArgumentException("Not enough names parsed");
            }
            _firstName = "";
            for(int i = 0; i < (split.Length-1);i++){
                _firstName = String.Concat(_firstName,split[i]," ");
            }
            _firstName = _firstName.Trim();
            _lastName = split[split.Length-1];
        }

        public string FirstName
        {
            get{return this._firstName;}
        }

        public string LastName
        {
            get{return this._lastName;}
        }

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