using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tips_lb1.netfram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void гравецьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.гравецьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fifaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fifaDataSet.команда' table. You can move, or remove it, as needed.
            this.командаTableAdapter.Fill(this.fifaDataSet.команда);
            // TODO: This line of code loads data into the 'fifaDataSet.гравець' table. You can move, or remove it, as needed.
            this.гравецьTableAdapter.Fill(this.fifaDataSet.гравець);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void findByCommand(string IdCommand)
        {
            this.командаTableAdapter.FillByPlayer(this.fifaDataSet.команда, IdCommand);
        }

        private void гравецьDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (гравецьDataGridView != null)
                {
                    DataGridViewRow selectedRow = гравецьDataGridView.Rows[e.RowIndex];
                    string CommandId = Convert.ToString((selectedRow.Cells[3].Value));
                    findByCommand(CommandId);

                }
            }

        }
    }
}
