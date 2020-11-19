using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace notePade
{
    public class PersonelViewModel : INotifyPropertyChanged
    {
        public List<Personel> Personels;
        private Personel _personel;

        public Personel Personel
        {
            get { return _personel; }
            set { _personel = value; NotifyPropertyChanged("Personel"); }
        }

        public PersonelViewModel()
        {
            Personels = new List<Personel>
            {
                new Personel(1, "مهدی", "09332701165", "اصفهان 1"),
                new Personel(2, "علی", "09210834246", "اصفهان 2"),
                new Personel(3, "محمد", "09337490247", "اصفهان 3"),
                new Personel(4, "حسن", "09215641279", "اصفهان 4")
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string pr)
        {
            if (!string.IsNullOrEmpty(pr))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(pr));
            }
        }

        private int _id;

        [DisplayName("آیدی")]
        public int ID
        {
            get { return _id; }
            set {
                _id = value;
                Search(_id);
                NotifyPropertyChanged("ID");
            }
        }
        [DisplayName("نام")]
        public string Name { get; set; }
        [DisplayName("تلفن")]
        public string Tel { get; set; }
        [DisplayName("آدرس")]
        public string Address { get; set; }
        //////////////////////
        ///
        public void Search(int Id)
        {
            Personel = Personels.Where(c => c.ID == Id).FirstOrDefault();
            if (Personel == null)
            {
                Personel = new Personel() { ID = Id, Name = "چنین کاربری وجود ندارد" };
            }
        }
    }
}
