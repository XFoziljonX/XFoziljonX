using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_programming_first_project
{
    public partial class Form1 : Form
    {
        int temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            vaqt_kvant.Columns.Add("", "Protsessor");
            vaqt_kvant.Columns[0].Width = 60;
            vaqt_kvant.Columns.Add("", "Vaqt");
            vaqt_kvant.Columns[1].Width = 40;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jadval.Rows.Clear();
            jadval.Columns.Clear();

            jadval.Columns.Add("", "Jarayon");
            jadval.Columns[0].Width = 60;

            jadval.Columns.Add("", "Kelish vaqti");
            jadval.Columns[1].Width = 60;

            jadval.Columns.Add("", "Ishlash vaqti");
            jadval.Columns[2].Width = 60;

            if (pr_bor.Checked==true)
            {
                jadval.Columns.Add("", "Prioritet");
                jadval.Columns[3].Width = 60;
            }
            
            string n=jarayon.Text;
            int P=Convert.ToInt32(n);
            for(int i=0;i<P;i++)
            {
                jadval.Rows.Add("P"+Convert.ToString(i+1),"");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void algoritm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(algoritm.Text== "Charxpalak")
            {
                pr_yoq.Enabled = false;
                pr_bor.Checked = true;
            }

            else
            {
                pr_yoq.Enabled = true;
            }
            
            if(algoritm.Text== "Birinchi kelganga birinchi xizmat")
            {
                haydab_chiqar.Enabled = false;
                haydab_chiqarma.Checked = true;
            }

            else
            {
                haydab_chiqar.Enabled = true;
            }

        }

        private void protsessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = protsessor.Text;
            int n = vaqt_kvant.Columns.Count;
            vaqt_kvant.Rows.Clear();

            if (text != "")
            {
                for (int i = 0; i < Convert.ToInt32(text); i++)
                    vaqt_kvant.Rows.Add(Convert.ToString(i + 1) + "-protsessor", "");
            }
        }
    }
}
