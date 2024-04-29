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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void гравецьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гравецьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fifaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fifaDataSet.гравець' table. You can move, or remove it, as needed.
            this.гравецьTableAdapter.Fill(this.fifaDataSet.гравець);

        }

        private void гравецьDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            string PlayerName = this.toolStripTextBox1.Text.ToString();
            SearchByName(PlayerName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 search = new Form2();
            search.ShowDialog();
            
        }

        private void search1_Click(object sender, EventArgs e)
        {
            string PlayerName = this.comboBox1.Text.ToString();
            SearchByName(PlayerName);
        }

        private void SearchByName(string playerName)
        {
            this.гравецьTableAdapter.FillByName(this.fifaDataSet.гравець, playerName);
        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = this.п_І_ПTextBox.Text.ToString();
            DateTime dateTime = this.дата_народженняDateTimePicker1.Value;
            int idCom = int.Parse(this.id_командаTextBox1.Text);
            int idAmpl = int.Parse(this.id_амплуаTextBox1.Text);
            int height = int.Parse(this.зрістTextBox1.Text);
            int weight = int.Parse(this.вагаTextBox1.Text);
            int playerNum = int.Parse(this.номерTextBox1.Text);
            this.гравецьTableAdapter.Insert( name, dateTime, idCom, idAmpl, height, weight, playerNum);
            MessageBox.Show($"New player: {name}, succesfully added");
            this.гравецьTableAdapter.Fill(this.fifaDataSet.гравець);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int idPLayer = int.Parse(this.id_гравецьTextBox2.Text);
            string name = this.п_І_ПTextBox1.Text.ToString();
            this.гравецьTableAdapter.DeletePlayer(this.fifaDataSet.гравець, idPLayer);
            MessageBox.Show($"Player: {name}, succesfully deleted");
            SearchByName("");          
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int idPLayer = int.Parse(this.id_гравецьTextBox3.Text);
            string name = this.п_І_ПTextBox2.Text.ToString();
            DateTime dateTime = this.дата_народженняDateTimePicker3.Value;
            int idCom = int.Parse(this.id_командаTextBox3.Text);
            int idAmpl = int.Parse(this.id_амплуаTextBox3.Text);
            int height = int.Parse(this.зрістTextBox3.Text);
            int weight = int.Parse(this.вагаTextBox3.Text);
            int playerNum = int.Parse(this.номерTextBox3.Text);
            this.гравецьTableAdapter.UpdatePlayer(this.fifaDataSet.гравець, idPLayer, name, dateTime, idCom, idAmpl, height, weight, playerNum);
            MessageBox.Show($"Info about player: {name}, succesfully updated");
            SearchByName("");
        }

    }
}
