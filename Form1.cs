using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungAndDrag.GamePieces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DungAndDrag
{
    public partial class Form1 : Form
    {
        Map currentMap;
        List<Character> _actorList;
        

        public Form1()
        {
            InitializeComponent();
            int i, j;
            currentMap = new Map("FirstMap", 40, 8, 8);
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    this.Controls.Add(currentMap.getTiles()[i,j]);
                }
            }
            currentMap.RefreshMap();
            _actorList = new List<Character>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            popup.ShowDialog();
            string[] charLoc = popup.EnteredText;
            popup.Dispose();
            Character bob = new Character("Bob");
            _actorList.Add(bob);
            currentMap.getTiles()[Int32.Parse(charLoc[0]), Int32.Parse(charLoc[1])].character = bob;
            currentMap.getTiles()[Int32.Parse(charLoc[0]), Int32.Parse(charLoc[1])].Image = Image.FromFile("C:\\Users\\Daniel\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\Resources\\knight.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            popup.ShowDialog();
            string[] charLoc = popup.EnteredText;
            popup.Dispose();
            Character ellen = new Character("Ellen");
            _actorList.Add(ellen);
            currentMap.getTiles()[Int32.Parse(charLoc[0]), Int32.Parse(charLoc[1])].character = ellen;
            currentMap.getTiles()[Int32.Parse(charLoc[0]), Int32.Parse(charLoc[1])].Image = Image.FromFile("C:\\Users\\Daniel\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\Resources\\archer.png");
        }

        public string InfoBox
        {
            get
            {
                return InfoBox;
            }
            set { readOnlyTextBox1.Text = value; }
        }

        public List<Character> actorList
        {
            get
            {
                return _actorList;
            }
            
        }

        public int[] RecentRolls
        {
            get
            {
                return RecentRolls;
            }
            set
            {
                readOnlyTextBox2.Text = value[0].ToString();
                readOnlyTextBox3.Text = value[1].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AttackForm popup = new AttackForm(this);
            popup.ShowDialog();
            popup.Dispose();
        }
    }
}
