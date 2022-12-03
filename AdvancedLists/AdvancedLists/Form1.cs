using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            // differents ways of list and how to handle it
            #region
            List<string> people = new List<string>() ; // generic list, no limits

            people.Add("Miguel");
            people.Add("Sara");
            people.Add("Roco");
            people.Add("Luli");

            /*listBox1.Items.Add(people[0]);
            listBox1.Items.Add(people[1]);
            listBox1.Items.Add(people[2]);
            listBox1.Items.Add(people[3]);
            */
            // people.Remove("Sara");
            //people.Clear(); // clear all list

            //people.RemoveAt(3); // luli is out


            /*            if (people.Remove("Luli"))
                        {
                            MessageBox.Show("Luli is out!");
                        }// luli is out

                        else
                        {
                            MessageBox.Show("its no possivel, person not found!");}
             */

            /* if (people.Contains("Luli")) 
             {
                 MessageBox.Show("Contain!");
             }
             */

            /*if (people.Count > 2) 
            {
                MessageBox.Show($"Got it! List has {people.Count}");
            }
            */

            //people.Sort();

            // MessageBox.Show($"Miguel is index {people.IndexOf("Miguel")}");

            // people.Insert(2, "Rodrigo");Insert and move all next forward

            // people.RemoveAt(3); luli out



            foreach (string person in people)
            {
                listBox1.Items.Add(person);
            }
            
            #endregion

            #region
            //string[] people = { "Sara", "Miguel", "Carola" };
            //listBox1.Items.AddRange(people);
            #endregion


        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();

            //HashSet<string> vehicles = new HashSet<string>() // not contain repeated items
            //{
            //    "Car", "Motorcycle", "Plane", "Boat", "Helicopter"
            //};

            //if (vehicles.Add("Plane"))
            //{
            //    MessageBox.Show("Adiciona Sarlongo");
            //}
            //else
            //{
            //    MessageBox.Show("Cannot add!");
            //};
            
            //foreach (string vehicle in vehicles) 
            //{
            //    listBox1.Items.Add(vehicle);
            //}
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            //Dictionary<int, string> names= new Dictionary<int, string>()
            ////        <key, value>
            //// cannot repeat keys, just values
            //{
            //    { 1, "Miguel" },
            //    { 2, "Sarlonga" },
            //    { 100, "Milonguita" },
            //    { 10, "Durisimo" },
            //    { 98, "John" },
            //    { 4, "Sarlonga" }
            //};

            //names.Add(32, "Who knows...");
            //// nomes.Remove(10); // Durisimo is out
            //// nomes.Clear();

            ////MessageBox.Show("First =" + nomes.First());
            ////MessageBox.Show("First =" + nomes.First().Key + ": " + nomes.First().Value );
            ////MessageBox.Show("Last =" + nomes.Last());
            

            //foreach (KeyValuePair<int, string> name in names
            //{
            //    //listBox1.Items.Add(nome.Value);
            //    listBox1.Items.Add($"{name.Key} = {name.Value}");
            //}

            ////MessageBox.Show($"Number nomes = {nomes.Count}");
            

        }

        private void btnSorted_Click(object sender, EventArgs e)
        {
            //SortedList<int, string> alumns = new SortedList<int, string>()
            //{
            //    { 23, "Albert" },
            //    { 67, "Xenia" },
            //    { 12, "Fonseca" }
            //};
            //alumns.Add(14, "Kuku");
            //// alumns.Remove(67);
            //// alumns.RemoveAt(2);
            //// alumns.Count();
            //// alumns.Contains(12);
            //foreach (KeyValuePair<int, string> alumn in alumns.Reverse()) 
            //{
            //    listBox1.Items.Add($"{alumn.Key} {alumn.Value}");
            //}
        }

        private void btnDict_Click(object sender, EventArgs e)
        {
            //SortedDictionary<string, string> names = new SortedDictionary<string, string>()
            //{
            //    { "Lufus", "Albert" },
            //    { "Vladimir", "Xenia" },
            //    { "Cabj", "Fonseca" }
            //};

            //names.Add("Losoria", "Claudia");
            //// names. values

            //foreach (KeyValuePair<string, string> name in names) 
            //{ 
            //    listBox1.Items.Add($"{name.Key} {name.Value}");
            //}
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //SortedSet<string> chains = new SortedSet<string>()
            //{
            //    "Kusulo", "Ainstain", "Pele","Messi", "Maradona"
            //};

            //// chains. and play with values as we saw on HashSet!

            //if (chains.Add("Pele"))
            //{
            //    MessageBox.Show("Faviola added!");
            //}
            //else
            //{
            //    MessageBox.Show("name already on set");
            //}
            //    foreach (string chain in chains) 
            //{ 
            //    listBox1.Items.Add (chain);
            //}
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            //Queue<string> rows = new Queue<string>(); FIFO
            //    rows.Enqueue("Me");
            //    rows.Enqueue("You");
            //    rows.Enqueue("They");
            //    rows.Enqueue("Others");
            //MessageBox.Show(rows.Count().ToString());

            //foreach (string row in rows )
            //{
            //    listBox1.Items.Add(row);
            //}
            //// MessageBox.Show(rows.Peek()); // first object
            //MessageBox.Show(rows.Dequeue()); // remove first object FIFO
            //MessageBox.Show(rows.Count().ToString());
            // MessageBox.Show("First element " + rows.First());
            // MessageBox.Show("First element " + rows.Last());
            
            //while (rows.Count > 0)
            //{
            //    foreach (string row in rows)
            //{
            //    listBox1.Items.Add(row); // poc Dequeue
            //}
            //    MessageBox.Show(rows.Dequeue());
            //    MessageBox.Show(rows.Count().ToString());
            //    listBox1.Items.Clear();
            //}
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack<string> pila = new Stack<string>();  // FILO

            pila.Push("Miguel");
            pila.Push("Paula");
            pila.Push("Marie");

            MessageBox.Show(pila.Count().ToString());

            foreach (string item in pila)
            {
                listBox1.Items.Add(item); // POC 1- Marie, 2- Paula, 3- Miguel
            }

            // MessageBox.Show(pila.Peek()); // Marie
            while (pila.Count() > 0)
            {
                MessageBox.Show(pila.Pop()); // Remove Marie
                MessageBox.Show(pila.Count().ToString());
                listBox1.Items.Clear();

                foreach (string item in pila)
                {
                    listBox1.Items.Add(item); 
                }

            }

        }
    }
}





















