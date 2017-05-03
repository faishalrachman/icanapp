﻿using iCAN.GUI;
using iCAN.GUI.Admin;
using iCAN.GUI.Guru;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace iCAN
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var form = new frmLogin();
            form.Show();
            form.Focus();
        }
    }
}
