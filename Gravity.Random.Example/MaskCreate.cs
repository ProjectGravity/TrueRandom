﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using Gravity.TrueRandom;
using System.IO;

namespace Gravity
{
    class Random_Gravity
    {
        ///this library can be used seperately
        ///it will auto-detect if random lib is available
        static int length = 20;
        const string Mask1 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        const string Mask2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-+=";
        const string Mask3 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%&'()*+,-./:;<=>?@[]^_`{|}~";
        static void Main(string[] args)
        {
            if (Type.GetType("Gravity.TrueRandom.RandomUtils") != null) { // if RandomUtils is available
            //Use truerandom lib

            }
            else {
              // use standard lib
              string a = GenPass(Alpha1, length);
              string b = GenPass(Alpha2, length);
              string c = GenPass(Alpha3, length);
            }
            //byte[] b = CombineByteArray(a);
            //string e = Convert.ToBase64String(b);
            //string c = Utilities.Base32.ToBase32String(b);
            //Console.WriteLine("Base 64 = " + e);
            Console.WriteLine("String [A-Z][0-9] = " + a);
            Console.WriteLine("String [A-Z][0-9][SpChCasual] = " + b);
            Console.WriteLine("String [A-Z][0-9][SpChAll] = " + c);
            /*using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(a);
                writetext.WriteLine(b);
                writetext.WriteLine(c);
            } */
            Thread.Sleep(int.MaxValue);
        }

        public static string GenPass(string valid, int length1){
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length1--)
            {
                char c = valid[rnd.Next(0, valid.Length)];
                if ("+-&|!(){}[]^\"~*?:\\".Contains(c))
                {
                    //res.Append("\\\\");
                }
                res.Append(c);
            }
            return res.ToString();
        }
    }
}
