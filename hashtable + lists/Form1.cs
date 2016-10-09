using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace hashtable___lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Subjects { English, IT, Science, Design, Math };


        private void button1_Click(object sender, EventArgs e)
        {
            List<string> students = new List<string>();
            students.Add("Jenny");
            students.Add("Peter");
            students.Add("Mary Jane");

            foreach(string child in students)
            {
                listBox1.Items.Add(child);
            }
            students.Add("Azhar");
            listBox1.Items.Add("new item =" + students[3]);

            students.Sort();
            listBox1.Items.Add("==============");
            foreach(string child in students)
            {
                listBox1.Items.Add(child);
            }
            students.RemoveRange(0, 2);
            listBox1.Items.Add("--------------");
            foreach(string child in students)
            {
                listBox1.Items.Add(child);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hashtable students = new Hashtable();

            students["Jenny"] = 87;
            students["peter"] = "No Score"; ;
            students["Mary-Jane"] = 64;
            students["Azhar"] = 79;

            foreach (DictionaryEntry child in students)
            {
                listBox1.Items.Add("Students: " + child.Key + ", Score: " + child.Value);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subjects newSubject = Subjects.Science;

        }
    }
}
