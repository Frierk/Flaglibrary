namespace Flaglibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        pictureBox1.Image = Properties.Resources.meatballs_1;
                        pictureBox2.Image = Properties.Resources.Flag_of_Sweden;
                        pictureBox3.Image = Properties.Resources.Ulf_Kristerson;
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        pictureBox1.Image = Properties.Resources.Hamburger;
                        pictureBox2.Image = Properties.Resources.Flag_of_the_United_States;
                        pictureBox3.Image = Properties.Resources.donald_trump;
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        pictureBox1.Image = Properties.Resources.Fish_and_Chips;
                        pictureBox2.Image = Properties.Resources.Flag_of_the_United_Kingdom;
                        pictureBox3.Image = Properties.Resources.King_Charles;
                    }
                    if (comboBox1.SelectedIndex == 3)
                    {
                        pictureBox1.Image = Properties.Resources.Peking_Duck;
                        pictureBox2.Image = Properties.Resources.Flag_of_China;
                        pictureBox3.Image = Properties.Resources.Xi_Jinping;
                    }
                }
            if (comboBox2.SelectedIndex == 1)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        pictureBox1.Image = Properties.Resources.Swedenfoodpast;
                        pictureBox2.Image = Properties.Resources.OldSwedishFlag;
                        pictureBox3.Image = Properties.Resources.Gustav_Vasa;
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        pictureBox1.Image = Properties.Resources.pork_tamales;
                        pictureBox2.Image = Properties.Resources.Flag_of_the_United_States_Old;
                        pictureBox3.Image = Properties.Resources.George_Washington;
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        pictureBox1.Image = Properties.Resources.Haggish;
                        pictureBox2.Image = Properties.Resources.Flag_of_England;
                        pictureBox3.Image = Properties.Resources.king_george_3;
                    }
                    if (comboBox1.SelectedIndex == 3)
                    {
                        pictureBox1.Image = Properties.Resources.Tea_egg;
                        pictureBox2.Image = Properties.Resources.Flag_of_China_Old;
                        pictureBox3.Image = Properties.Resources.QinShiHuang;
                    }
                }
        }
    }
}