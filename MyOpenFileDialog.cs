using System;
using System.Windows.Forms;

namespace Project_3
{
    internal class MyOpenFileDialog
    {
        public MyOpenFileDialog()
        {
        }

        public static implicit operator OpenFileDialog(MyOpenFileDialog v)
        {
            throw new NotImplementedException();
        }
    }
}