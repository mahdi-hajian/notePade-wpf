using System;
using System.Collections.Generic;
using System.Text;

namespace notePade
{
    public class Personel
    {
        public Personel(int iD, string name, string tel, string address)
        {
            ID = iD;
            Name = name;
            Tel = tel;
            Address = address;
        }
        public Personel()
        {

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
    }
}
