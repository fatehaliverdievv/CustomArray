using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customarray
{
    internal class Customarray
    {
        string[] _arr;
        public int Length { get =>_arr.Length; }

        public string this [int index]
        { 
            get 
            {
                if (index < _arr.Length)
                {
                    return _arr[index]; 
                }
                else
                {
                    throw new Exception();
                }
            } 
            set 
            {
                if (index < _arr.Length)
                {
                   _arr[index]=value;
                }
                else
                {
                    throw new Exception();
                }
            } 
        }
        public Customarray()
        {
            _arr = new string[0];
        }
        public Customarray(int length)
        {
            _arr=new string[length];
        }
        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length+1);
            _arr[_arr.Length-1] = str;
        }
    }
}
