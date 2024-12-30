using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Encapsulation
{
    internal struct PhomeBook
    {
        #region Attributes
        string[] Names;
        int[] Numbers;
        public int Size {  get; set; }
        #endregion
        #region Constructors
        public PhomeBook(int Size)
        {
            Names = new string[Size];   
            Numbers = new int[Size];
            this.Size = Size;
            
        }
        #endregion
        #region Methods
        public void AddPerson(int position, string Name, int Number)
        {
           if (Numbers is not null && Names is not null)
            {
                if (position < Size)
                {
                    Names[position] = Name;
                    Numbers[position] = Number;
                }
            }
        }

        #endregion
        #region Getter - Setter
        public int Getphone(string Name)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == Name)
                {
                    return Numbers[i];
                }
            }
            return 0;
        }

        public void SetNumber(string Name, int NewNumber)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == Name)
                {
                    Numbers[i] = NewNumber;
                    break;
                }
            }
        }
        //INDEXER PROBIRETY
        public int this[string Name]
        {
            get
            {
                for (int i = 0; i < Names.Length; i++)
                
                    if (Names[i] == Name)
                    
                        return Numbers[i];
                    
                
                return 0;
            }
            set
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i] == Name)
                    {
                        Numbers[i] = value;
                        break;
                    }
                }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"index::{index} Name{Names[index]} Phone::{Numbers[index]}";
            }
        }
        #endregion
    }
}
