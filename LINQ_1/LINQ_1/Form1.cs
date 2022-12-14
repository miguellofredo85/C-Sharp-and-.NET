using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {
        List<string> list_nomes;
        List<int> numbers;
        Dictionary<string, double> products;
        Dictionary<string, string> list_status;
        public Form1()
        {
            InitializeComponent();
            // data 
            #region list_nomes
            list_nomes = new List<string>();
            list_nomes.Add("Miguel");
            list_nomes.Add("Charles");
            list_nomes.Add("Arthur");
            list_nomes.Add("Louise");
            list_nomes.Add("Lucy");
            list_nomes.Add("Monic");
            list_nomes.Add("Annabelle");
            list_nomes.Add("Ailin");
            list_nomes.Add("Gabriel");
            list_nomes.Add("Micaela");
            list_nomes.Add("Valente");
            list_nomes.Add("Messi");
            list_nomes.Add("Maradona");
            #endregion

            #region numbers
            numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(8);
            numbers.Add(21);
            numbers.Add(2);
            numbers.Add(43);
            numbers.Add(87);
            numbers.Add(4);
            numbers.Add(17);
            numbers.Add(32);
            numbers.Add(10);
            #endregion

            #region products

            products= new Dictionary<string, double>();
            products.Add("Keyboard", 56.23);
            products.Add("Mouse", 23.12);
            products.Add("Tv", 567.12);
            products.Add("Notebook", 1000.65);
            products.Add("Memory 8gb", 35.78);
            products.Add("Motherboard", 543.67);
            products.Add("PC ATX", 200.89);
            products.Add("USB", 23.43);
            products.Add("Playstation", 2000.54);
            products.Add("Xbox", 1800.45);
            products.Add("Nintendo", 33.50);

            #endregion

            #region list_states
            list_status = new Dictionary<string, string>();
            list_status.Add("Bs As", "Argentina");
            list_status.Add("Rio de Janeiro", "Brazil");
            list_status.Add("Sao Paulo", "Brazil");
            list_status.Add("Cuzco", "Peru");
            list_status.Add("Mendoza", "Argentina");
            list_status.Add("Bogota", "Colombia");
            list_status.Add("Lima", "Peru");
            list_status.Add("Medellin", "Colombia");
            list_status.Add("Chaco", "Argentina");
            #endregion
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            
            ////LINQ (get data, make a query, execute query)
            
            //IEnumerable<int> result = from num in numbers where num % 2 == 0 select num; // query
            //// this sentence is better than forech because wont go through all list, just evens
            //// can use var but IEnumerable woulb "correct"

            //foreach (int num in result)
            //{

            //    listBox.Items.Add(num);
            //}
            string txt = txtSearch.Text;
            IEnumerable<string> result = from name in list_nomes 
                                         where name.StartsWith(txt) 
                                         select name;
            listBox.Items.AddRange(result.ToArray()); // 
            //foreach (string item in result)
            //{
            //    listBox.Items.Add(item);
            //}

        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            // filter where
            string txt = txtSearch.Text.ToLower();
            var result = from nome in list_nomes 
                         where nome.ToLower().Contains(txt) 
                         select nome;

            foreach (var n in result)
            {
                listBox.Items.Add(n);
            }
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            string txt = txtSearch.Text;

            // var result = from num in numbers orderby num descending where num <= 10 select num;
            // var result = from num in list_nomes orderby num ascending select num;
            var result = from prod in products  orderby prod.Key descending select prod;

            foreach (KeyValuePair<string, double> n in result)
            {
                listBox.Items.Add(n.Key + " R$ " + n.Value);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            // groupby filter

            listBox.Items.Clear();

            string txt = txtSearch.Text;

            var result = from state in list_status 
                         group state 
                         by state.Value;
            foreach (var group in result)
            {
                listBox.Items.Add(group.Key); // item.Key cause Key is from var result
                    foreach (var city in group)
                {
                    listBox.Items.Add("   " + city.Key);
                }          
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            //int count1 = (from name in list_nomes where name.StartsWith("G") select name).Count();

            //listBox.Items.Add(count1 + " names stating with G");

            //double average = numbers.Average();
            //listBox.Items.Add(average);

            //var query = from num in numbers where num <= 10 select num;
            //var result = query.Average();
            //listBox.Items.Add(result);

            //int sum = numbers.Sum();
            //listBox.Items.Add(sum + " sum numbers"); 

            string maxlenght = list_nomes.Aggregate((max, min) => {

                if (max.ToString().Length > min.ToString().Length)
                {
                    return max;
                }
                else 
                { 
                    return min;
                }
            
            });

            listBox.Items.Add(maxlenght + " max lenght name");
        }

        private void btnElement_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            int first = numbers.FirstOrDefault(); // OrDefault is cause if list number is empty it return 0
            listBox.Items.Add(first);

            int last = numbers.LastOrDefault(); 
            listBox.Items.Add(last);

            int index = numbers.ElementAtOrDefault(4);
            listBox.Items.Add(index);
        
            var consult = from num in numbers where num > 1000 select num;
            listBox.Items.Add(consult.FirstOrDefault());
        }

        private void btnLinqLamda_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            ////var query = from name in list_nomes select name;
            //var queryLambda = list_nomes.Select(name => name); // query with lambda
            //listBox.Items.AddRange(queryLambda.ToArray());

            //var query = from name in list_nomes where name.StartsWith("M") select name;
            //var queryLambda = list_nomes.Where(name=> name.StartsWith("M")); // query with lambda
            //listBox.Items.AddRange(queryLambda.ToArray());

            //var query = from name in list_nomes orderby name select name;
            ////var queryLambda = list_nomes.OrderBy(name => name);
            //var queryLambda = list_nomes.OrderByDescending(name => name);
            //listBox.Items.AddRange(queryLambda.ToArray());

            //var query = from state in list_status group state by state.Value;
            var queryLambda = list_status.GroupBy(state => state.Value);

            foreach ( var item in queryLambda )
            {
                listBox.Items.Add(item.Key);
                    foreach ( var item2 in item) 
                    { 
                        listBox.Items.Add("    " + item2.Key);
                    }
            }
        
        }
    }
}


