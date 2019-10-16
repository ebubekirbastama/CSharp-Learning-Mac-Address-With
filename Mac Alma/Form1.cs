using System;
using System.Management;
using System.Windows.Forms;
//Coding By& Siyah Muhafız...
namespace Mac_Alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Coding By& Siyah Muhafız...
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Mac();
        }
        string Mac()
        {
            ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject obj in manager.GetInstances())
            {
                if ((bool)obj["IPEnabled"])
                {
                    return obj["MacAddress"].ToString();
                }
            }

            return String.Empty;
        }
    }
}
