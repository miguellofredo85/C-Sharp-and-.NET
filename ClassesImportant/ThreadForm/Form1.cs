using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        //private delegate void ControlAct(Control controle, string properties, object value);

        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Work));
            t.IsBackground = true;


        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            t.Start();
            if(!t.IsAlive)
            {
                t.Start();
            }
        }

        private void Work()
        { 
            while (true)
            {
                //lblResult.Text = DateTime.Now.Second.ToString();
                //ValuePropDefinition(lblResult, "Text", DateTime.Now.ToString());
                // another way to do this is uncomment ValuePropDefinition up and the method down and the delegate ControlActand here do the next
                lblResult.Invoke(new Action(() => lblResult.Text = DateTime.Now.ToString() ));
            }

        }
        //private void ValuePropDefinition(Control controle, string properties, object value)
        //{
        //    if (controle.InvokeRequired)
        //    {
        //        ControlAct d = new ControlAct(ValuePropDefinition);
        //        controle.Invoke(d, new object[] { controle, properties, value });
        //    }
        //    else
        //    {
        //        Type t = controle.GetType();
        //        PropertyInfo[] props = t.GetProperties();

        //        foreach (PropertyInfo pi in props)
        //        {
        //            if (pi.Name.ToUpper() == properties.ToUpper())
        //            {
        //                pi.SetValue(controle, value, null);
        //            }
        //        }
        //    }

        //}
    }
}






