﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    public class statrolldice
    {
        public static Byte DiceRollforstats()
        {


       
            List<byte> dicearray = new List<byte>(4);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            dicearray.Add(new Dice().Value);
            //for (Byte i = 0; i < 4; i++)
            //{
            //   dicearray[i] = (new Dice());
            //}
            Byte lowest = Convert.ToByte(dicearray[0]);
            Byte lowestindex = 0;
            for (Byte i = 1; i < 4; i++)
            {
                if (lowest > Convert.ToByte(dicearray[i]))
                {
                    lowest = Convert.ToByte(dicearray[i]);
                    lowestindex = i;

                }


            }
            dicearray.RemoveAt(lowestindex);
            Byte sum = Convert.ToByte(dicearray[0]);
            sum += Convert.ToByte(dicearray[1]);
            sum += Convert.ToByte(dicearray[2]);
            return sum;
        }
    }
}
