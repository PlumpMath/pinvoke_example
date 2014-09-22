using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dotnetui
{
  public partial class Form1 : Form
  {
    [DllImport("compiledlib.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int addnumbers(int paramone, int paramtwo);

    public Form1()
    {
      InitializeComponent();
    }

    private void BtnCalculateClick(object sender, EventArgs e)
    {
      int numOne = Convert.ToInt32(txtFirstNumber.Text);
      int numTwo = Convert.ToInt32(txtSecondNumber.Text);

      int result = addnumbers(numOne, numTwo);

      lblResult.Text = result.ToString(CultureInfo.InvariantCulture);

    }
  }
}
