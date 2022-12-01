using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
            comboCS.Items.Add("Married");
            comboCS.Items.Add("Single");
            comboCS.Items.Add("Split");
            comboCS.Items.Add("Widow");
            comboCS.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (Person person in persons)
            {
                if (person.Name == txtName.Text)
                {
                    index = persons.IndexOf(person);
                }
            }
            if (txtName.Text == "") // Verif Name, then Phone,
            {
                MessageBox.Show("Name Incomplete");
                txtName.Focus();
                return;
            }
            if (txtPhone.Text == "(  )     -" || txtPhone.Text.Length < 14)
            {
                MessageBox.Show("Phone Incomplete");
                txtPhone.Focus();
                return;
            }
            char sex; // Verrification Gender
            if (radioM.Checked)
            {
                sex = 'M';
            }
            else if (radioF.Checked)
            {
                sex = 'F';
            }
            else
            {
                sex = 'O';
            }
            Person p = new Person();
            p.Name = txtName.Text;
            p.BirthDate = txtDate.Text;
            p.Phone= txtPhone.Text;
            p.Civil = comboCS.SelectedItem.ToString();
            p.House = checkHouse.Checked;
            p.Car = checkCar.Checked;
            p.Gender = sex;

            if (index < 0 )
            {
                persons.Add(p);
            }
            else
            {
                persons[index] = p;
            }
            btnClear_Click(btnClear, EventArgs.Empty);

            List();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtDate.Text = "";
            comboCS.SelectedIndex = 0;
            checkHouse.Checked = false;
            checkCar.Checked = false;
            radioF.Checked = false;
            radioM.Checked = false;
            radioO.Checked = true;
            txtName.Focus();
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            int indice = list.SelectedIndex;
            persons.RemoveAt(indice);
            List();

        }
        private void List()
        {
            list.Items.Clear();
            foreach (Person p in persons)
                {
                list.Items.Add(p.Name);
            }
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = list.SelectedIndex;
            Person p = persons[index];

            txtPhone.Text = p.Phone;
            txtName.Text = p.Name;
            txtDate.Text = p.BirthDate;
            checkCar.Checked = p.Car;
            checkHouse.Checked = p.House;
            comboCS.SelectedItem = p.Civil;

            switch (p.Gender)
            {
                case 'F':
                    radioF.Checked = false;
                    break;
                case 'M':
                    radioM.Checked = false;
                    break;
                default: 
                    radioO.Checked = false; 
                    break;
            }
        }
    }
}
