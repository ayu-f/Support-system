﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotIsSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                TelegraBotHelper hlp = new TelegraBotHelper(token: "MyToken");
                hlp.GetUpdates();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}