﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace com.digitalwave.iCare.gui.HIS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmUploadMain(args));
        }
    }
}