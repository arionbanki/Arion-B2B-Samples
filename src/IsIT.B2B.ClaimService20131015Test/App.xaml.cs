using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IsIT.B2B.ClaimService20131015Test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //Handling the exception within the UnhandledException handler.
            if (e.Exception.InnerException != null)
            {
                MessageBox.Show(e.Exception.InnerException.Message, "Villa!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show(e.Exception.Message, "Villa!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            e.Handled = true;
        }
    }
}
