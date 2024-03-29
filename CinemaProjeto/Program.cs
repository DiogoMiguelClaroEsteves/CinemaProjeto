﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProjeto
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool temCinema = false;
            using (var db = new CinemaContext())
            {
                var cinema = db.Cinemas.FirstOrDefault();
                if (cinema == null)
                {
                    temCinema = false;
                }
                else
                {
                    temCinema = true;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
