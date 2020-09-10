using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WorlWithAPI.Models.Navigation
{
    public class DialogManager : IDialogManager
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
