using DungAndDrag.GamePieces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungAndDrag
{
    public partial class AttackForm : Form
    {
        Form1 _form1;
        public AttackForm(Form1 baseForm)
        {
            InitializeComponent();
            _form1 = baseForm;
            foreach (Character actor in baseForm.actorList)
            {
                comboBox1.Items.Add(actor);
                comboBox2.Items.Add(actor);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form1.RecentRolls = ((Character)comboBox1.SelectedItem).attackRoll((Character)comboBox2.SelectedItem);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
