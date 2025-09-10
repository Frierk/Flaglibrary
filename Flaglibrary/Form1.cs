namespace Flaglibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
