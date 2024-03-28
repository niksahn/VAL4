using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAL4
{
    public partial class Form1 : Form
    {
        double[][] Matrix = new double[1][];
        double[] Val = new double[1];
        GausMethod gaus;
        public Form1()
        {
            InitializeComponent();
            freeData.Columns.Add("0", "");
            GetRandomMatrix();
            PrintUserMatrix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gaus = new GausMethod(Matrix,Val);
            switch (gaus.SolveMatrix())
            {
                case 1: { MessageBox.Show("нет решений "); return; }
                case 2: { MessageBox.Show("множество решений "); return; }
            }

            iteraction.Items.Clear();
            for (int i = 0 ; i < gaus.Iterations.Count;i++)
            {
                iteraction.Items.Add(i);
            }
            FillTable(IterationsDataGauss, gaus.Iterations[0]);
            FillTable(rezGaus, gaus.Answer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetRandomMatrix();
            PrintUserMatrix();
        }


        private void GetRandomMatrix()
        {
            int num = (int)n.Value;
            Random rand = new Random();
            Matrix = new double[num][];
            Val = new double[num];
            for (int i = 0; i < num; i++)
            {
                Matrix[i] = new double[num];
                Val[i] = rand.Next(1000) // + rand.NextDouble()
                    ;
                for (int ii = 0; ii < num; ii++)
                {
                    Matrix[i][ii] = rand.Next(1000)// + rand.NextDouble()
                        ;
                }
            }
        }

        private void PrintUserMatrix()
        {
            FillTable(koefData, Matrix);
            FillTable(freeData, Val);
        }

        private void FillTable(DataGridView e, double[][] matrix)
        {
            e.Rows.Clear();
            e.Columns.Clear();
            int num = matrix.Length;
            int cur = 0;
            for (int i = 0; i < num; i++)
            {
                e.Columns.Add(i.ToString(), "");
            }
            foreach (var i in matrix)
            {
                e.Rows.Add();
                int curCell = 0;
                foreach (var ii in i)
                {
                    e.Rows[cur].Cells[curCell].Value = ii.ToString();
                    curCell++;
                }
                cur++;
            }
        }

        private void FillTable(DataGridView e, List<List<double>> matrix)
        {
            e.Rows.Clear();
            e.Columns.Clear();
            int numColumns = matrix[0].Count;
            int cur = 0;
            for (int i = 0; i < numColumns; i++)
            {
                e.Columns.Add(i.ToString(), "");
            }
            foreach (var i in matrix)
            {
                e.Rows.Add();
                int curCell = 0;
                foreach (var ii in i)
                {
                    e.Rows[cur].Cells[curCell].Value = ii.ToString();
                    curCell++;
                }
                cur++;
            }
        }

        private void FillTable(DataGridView e, double[] matrix)
        {
            e.Columns.Clear();
            e.Columns.Add("", "");
            e.Rows.Clear();
            int num = matrix.Length;
            int cur = 0;
            cur = 0;
            foreach (var i in matrix)
            {
                e.Rows.Add();
                e.Rows[cur].Cells[0].Value = i.ToString();
                cur++;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int num = (int)n.Value;
            Matrix= new double[num][];
            Val = new double[num];
            for (int i = 0; i < num; i++)
            {
                Matrix[i] = new double[num];
            }
                PrintUserMatrix();
        }
       
        private void koefData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Matrix[e.RowIndex][e.ColumnIndex] = double.Parse(koefData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            catch
            {
                MessageBox.Show("неверное значение");
                PrintUserMatrix();
            }
        }

        private void freeData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Val[e.RowIndex] = double.Parse(freeData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            catch(Exception err)
            {
                MessageBox.Show("неверное значение");
                PrintUserMatrix();
            }
        }

        private void iteraction_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable(IterationsDataGauss, gaus.Iterations[iteraction.SelectedIndex]);
        }
    }
}
