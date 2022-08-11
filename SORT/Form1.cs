using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORT
{
    public partial class Form1 : Form
    {
        string[] patternP1,
                patternP2,
                patternX,
                patternX1,
                patternX2,
                patternOZ ,
                patternOnZ;
        public Form1()
        {
            InitializeComponent();
            string[] patternP1 = {"П1", "Проход 1", "Хозяева" }, 
                patternP2 = { "П2", "Проход 2", "Гости" }, 
                patternX = { "X", "Ничья" }, 
                patternX1 = { "X1", "Хозяева не проиграют" }, 
                patternX2 = { "X2", "Гости не проиграют" },
                patternOZ = { "ОЗ-да", "ОЗ - да", "Обе забьют - да", "обе забьют", "Обе забьют", "Обе забьют: Да", "Обе Забьют" }, 
                patternOnZ = { "ОЗ-нет", "ОЗ - нет", "Обе забьют - нет", "обе не забьют", "Обе не забьют", "Обе забьют: Нет" },
                patternTM1, 
                patternTM15, 
                patternTM2, 
                patternTM25, 
                patternTM3, 
                patternTB1, 
                patternTB15, 
                patternTB2, 
                patternTB25, 
                patternTB3,
                patternF1m05, 
                patternF1m1, 
                patternF1m15, 
                patternF1m2, 
                patternF1m25,
                patternF1p05, 
                patternF1p1, 
                patternF1p15, 
                patternF1p2, 
                patternF1p25,
                patternF2m05,
                patternF2m1,
                patternF2m15, 
                patternF2m2, 
                patternF2m25,
                patternF2p05, 
                patternF2p1, 
                patternF2p15, 
                patternF2p2, 
                patternF2p25,
                patternP1m15, 
                patternP1m2, 
                patternP1m25, 
                patternP1m3,
               patternP1b15,  
               patternP1b2, 
               patternP1b25, 
               patternP1b3,
               patternP2m15, 
               patternP2m2,
               patternP2m25, 
               patternP2m3,
               patternP2b15, 
               patternP2b2, 
               patternP2b25, 
               patternP2b3;
        }
        int P1, P2, X, X1, X2, 
            OZ, OnZ, 
            TM1, TM15, TM2, TM25, TM3, TB1,TB15, TB2, TB25, TB3, 
            F1m05, F1m1, F1m15, F1m2, F1m25, 
            F1p05, F1p1, F1p15, F1p2, F1p25, 
            F2m05, F2m1, F2m15, F2m2, F2m25, 
            F2p05, F2p1, F2p15, F2p2, F2p25,
            P1m15, P1m2, P1m25,P1m3,
            P1b15, P1b2, P1b25, P1b3,
            P2m15, P2m2, P2m25,P2m3,
            P2b15, P2b2, P2b25, P2b3;

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=par;Uid=devel;Pwd=devel;"))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                for (int r = 0; r <= dataGridView1.Rows.Count - 2; r++) {
                    command.CommandText = "INSERT INTO `prognoz`(`ID`, `KOM`, `DATA`, `rP1`, `rP2`, `X`, `rX1`, `rX2`, `rOZ`, `rOnZ`) " +
                        "VALUES (null,'"+ dataGridView1.Rows[r].Cells["KOM"].Value + 
                        "','" + dataGridView1.Rows[r].Cells["DATA"].Value + 
                        "'," + dataGridView1.Rows[r].Cells["rP1"].Value +
                        "," + dataGridView1.Rows[r].Cells["rP2"].Value +
                        "," + dataGridView1.Rows[r].Cells["rXX"].Value +
                        "," + dataGridView1.Rows[r].Cells["rX1"].Value +
                        "," + dataGridView1.Rows[r].Cells["rX2"].Value +
                        "," + dataGridView1.Rows[r].Cells["rOZ"].Value +
                        "," + dataGridView1.Rows[r].Cells["rOnZ"].Value +")";
                    command.ExecuteNonQuery();

                }
                connection.Close();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] patternP1 = { "П1", "Проход 1", "Хозяева" };
            string[] patternP2 = { "П2", "Проход 2", "Гости" };
            string[] patternX = { "X", "Ничья" };
            string[] patternX1 = { "Х1", "Хозяева не проиграют" };
            string[] patternX2 = { "Х2", "Гости не проиграют" };
            string[] patternOZ = { "ОЗ-да", "ОЗ - да", "Обе забьют - да", "обе забьют", "Обе забьют", "Обе забьют: Да", "Обе Забьют" };
            string[] patternOnZ = { "ОЗ-нет", "ОЗ - нет", "Обе забьют - нет", "обе не забьют", "Обе не забьют", "Обе забьют: Нет" };
            var _items = this.listBox2.Items.Cast<string>().Distinct().ToArray();
            var _items1 = this.listBox1.Items.Cast<string>().Distinct().ToArray();
            int i = 0;
            foreach (var item in _items)
            {
                int rowNumber = dataGridView1.Rows.Add(null,null,0,0,0,0,0,0,0);
                foreach (var item1 in _items1)
                {

                    String[] words1 = item1.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    String[] words = item.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    bool result = Regex.IsMatch(item1, "\\b" + words[0] + "\\b");
                    bool result1 = Regex.IsMatch(item1, ".*" + words[1] + ".*");
                    if (result == true && result1 == true)
                    {
                        listBox1.Items.Remove(item1);
                        _items1 = this.listBox1.Items.Cast<string>().Distinct().ToArray();
                        this.listBox3.Items.Add(words[0].Trim() + "|" + words[1] + "|" + words1[2]);


                        dataGridView1.Rows[rowNumber].Cells["KOM"].Value = words1[0].Trim();
                        dataGridView1.Rows[rowNumber].Cells["DATA"].Value = words[1];
                        for (int r = 0; r <= patternP1.Length - 1; r++)
                        {
                            bool res1 = Regex.IsMatch(item1.Trim(), "\\b" + patternP1[r] + "\\b");
                            if (res1) { dataGridView1.Rows[rowNumber].Cells["rP1"].Value = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["rP1"].Value) + 1; break; }

                        }
                        for (int r = 0; r <= patternP2.Length - 1; r++)
                        {
                            bool res1 = Regex.IsMatch(item1.Trim(), "\\b" + patternP2[r] + "\\b");
                            if (res1) { dataGridView1.Rows[rowNumber].Cells["rP2"].Value = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["rP2"].Value) + 1; break; }

                        }
                        for (int r = 0; r <= patternX.Length - 1; r++)
                        {
                            bool res1 = Regex.IsMatch(item1.Trim(), "\\b" + patternX[r] + "\\b");
                            if (res1) { dataGridView1.Rows[rowNumber].Cells["rXX"].Value = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["rXX"].Value) + 1; break; }

                        }
                        for (int r = 0; r <= patternX1.Length - 1; r++)
                        {
                            bool res1 = Regex.IsMatch(item1.Trim(), "\\b" + patternX1[r] + "\\b");
                            if (res1) { dataGridView1.Rows[rowNumber].Cells["rX1"].Value = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["rX1"].Value) + 1; break; }

                        }
                        for (int r = 0; r <= patternX2.Length - 1; r++)
                        {
                            bool res1 = Regex.IsMatch(item1.Trim(), "\\b" + patternX2[r] + "\\b");
                            if (res1) { dataGridView1.Rows[rowNumber].Cells["rX2"].Value = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["rX2"].Value) + 1; break; }

                        }
                        for (int r = 0; r <= patternOZ.Length - 1; r++)
                        {
                            bool res1 = Regex.IsMatch(item1.Trim(), "\\b" + patternOZ[r] + "\\b");
                            if (res1) { dataGridView1.Rows[rowNumber].Cells["rOZ"].Value = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["rOZ"].Value) + 1; break; }

                        }
                        for (int r = 0; r <= patternOnZ.Length - 1; r++)
                        {
                            bool res1 = Regex.IsMatch(item1.Trim(), "\\b" + patternOnZ[r] + "\\b");
                            if (res1) { dataGridView1.Rows[rowNumber].Cells["rOnZ"].Value = Convert.ToInt32(dataGridView1.Rows[rowNumber].Cells["rOnZ"].Value) + 1; break; }

                        }
                    }
                    i++;

                }
            }
            for (int w = 0; w < dataGridView1.Rows.Count - 1; w++)
            {

                if (dataGridView1.Rows[w].Cells["KOM"].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(w);
                    w--;
                }
                if (Convert.ToInt32(dataGridView1.Rows[w].Cells["rP1"].Value.ToString()) == 0 &
                Convert.ToInt32(dataGridView1.Rows[w].Cells["rP2"].Value.ToString()) == 0 &
                Convert.ToInt32(dataGridView1.Rows[w].Cells["rXX"].Value.ToString()) == 0 &
                Convert.ToInt32(dataGridView1.Rows[w].Cells["rX1"].Value.ToString()) == 0 &
                Convert.ToInt32(dataGridView1.Rows[w].Cells["rX2"].Value.ToString()) == 0 &
                Convert.ToInt32(dataGridView1.Rows[w].Cells["rOZ"].Value.ToString()) == 0 &
                Convert.ToInt32(dataGridView1.Rows[w].Cells["rOnZ"].Value.ToString()) == 0)
                {
                    dataGridView1.Rows.RemoveAt(w);
                    dataGridView1.Refresh();
                    w--;
                }
            }
        }
            
            

            private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection("Server=localhost;Database=par;Uid=devel;Pwd=devel;"))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "SELECT kom,data,res FROM vpliuse UNION ALL SELECT kom,data,res FROM rb UNION ALL SELECT kom,data,res FROM stavkiprognozy UNION ALL SELECT kom,data,res FROM odds UNION ALL SELECT kom,data,res FROM kushvsporte UNION ALL SELECT kom,data,res FROM betonmobile ORDER BY kom";

                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        listBox1.Items.Add(reader.GetString(0).Trim()+"|"+ reader.GetString(1) + "|" + reader.GetString(2));
                connection.Close();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////
            var _items = this.listBox1.Items.Cast<string>().Distinct().ToArray();
            this.listBox1.Items.Clear();
            foreach (var item in _items)
            {
                this.listBox1.Items.Add(item);
            }
            //////////////////////////////////////////////////////////////////////////////////////////
            var _items2 = this.listBox1.Items.Cast<string>().Distinct().ToArray();
            //this.listBox1.Items.Clear();
            foreach (var item in _items2)
            {

                Match match = Regex.Match(item, @".?\d[:]\d\d");
                if (match.Success)
                {
                    mak = match.Captures[0].Value;
                }
                String[] words = item.Split(new char[] { '-', '—', '–' }, StringSplitOptions.RemoveEmptyEntries);

                words[0] = Regex.Split(words[0], "vs")[0];
                words[0] = words[0].Replace(@"«", "");
                words[0] = words[0].Replace(@"»", "");
                this.listBox2.Items.Add(words[0].Trim() + "|" + mak);
            }
            //////////////////////////////////////////////////////////////
            var _items3 = this.listBox2.Items.Cast<string>().Distinct().ToArray();
            this.listBox2.Items.Clear();
            foreach (var item in _items3)
            {
                this.listBox2.Items.Add(item);
            }
            ///////////////////////////////////////////////////////////////
            int a = listBox2.Items.Count;
            for (var j = 0; j <= a - 1; j++)
                for (var i = 0; i <= a - 2; i++)
                {
                    string q = listBox2.Items[i].ToString();
                    string g = listBox2.Items[i + 1].ToString();
                    if (q.Length > g.Length)
                    {
                        var tmp = listBox2.Items[i];
                        listBox2.Items[i] = listBox2.Items[i + 1];
                        listBox2.Items[i + 1] = tmp;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        string mak;
        private void button3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            var _items = this.listBox2.Items.Cast<string>().Distinct().ToArray();
            var _items1 = this.listBox1.Items.Cast<string>().Distinct().ToArray();
            foreach (var item1 in _items1)
            {
                foreach (var item in _items)
                {

                    String[] words1 = item1.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    String[] words = item.Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                    bool result = Regex.IsMatch(item1, "\\b" + words[0] + "\\b");
                    bool result1 = Regex.IsMatch(item1, ".*" + words[1] + ".*");
                    if(result == true && result1 == true)
                    {
                        listBox1.Items.Remove(item1);
                        this.listBox3.Items.Add(words[0].Trim() + "|" + words[1] + "|" + words1[2]);
                        
                    }
                   
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
