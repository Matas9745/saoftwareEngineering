using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    class MatasUser
    {
        public string addName(string p_name)
        {
            string lastName = Microsoft.VisualBasic.Interaction.InputBox("Enter your last name, Last Name Input", "Last Name");
            p_name = p_name + " " + lastName;
            return p_name;
        }
    }
}
