﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Magazine : Item, IPubs
    {
        private int volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска

        public bool IfSubs { get; set; } // подписка на журнал

        private bool returnSrok;

        public Magazine(int volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


        public void ReturnSrok1()
        {
            returnSrok = true;
        }

        // реализация интерфейса
        public override void Return()    // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }


        public void Subs()
      {
            IfSubs = true; // устанавливаем флаг подписки в true
            // действия при оформлении подписки на журнал
        }
        public override string ToString()
        {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
       }
    }
}
