using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    public class CodeName
    {
        public string Code { get; set; }
        public string Name { get; set; } 

        public CodeName()
        {

        }
        public CodeName(string code, string name)
        {
            Code = code;
            Name = name;
        }

     
    }
}
