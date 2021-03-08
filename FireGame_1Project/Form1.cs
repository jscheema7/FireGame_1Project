using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_1Project
{
    public partial class Form1 : Form
    {
        int shoot = 0;
        int flag = 0;
        private Winner winner = new Winner();
        public Form1()
        {
            InitializeComponent();
            //caliing the method on load to check the accuracy of the file 
            onLoad();
        }
        public void onLoad() {
            load_btn.Enabled = false;
            spin_click.Enabled = false;
            shoot_click.Enabled = false;
            play_again.Enabled = false;
        }
        private void start_btn_game_Click(object sender, EventArgs e)
        {
            //here i am goig to disable the start button and enable the load button 
            start_btn_game.Enabled = false;
            load_btn.Enabled = true;
            pictureBox1.Image = FireGame_1Project.Properties.Resources.gif_start;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {

            //here i am goig to disable the load button and enable the spin button 
            load_btn.Enabled = false;
            spin_click.Enabled = true;
            pictureBox1.Image = FireGame_1Project.Properties.Resources.gif_load;
        }

        private void spin_click_Click(object sender, EventArgs e)
        {

            //here i am goig to disable the Spin button and enable the shot button 
            spin_click.Enabled = false;
            shoot_click.Enabled = true;
            pictureBox1.Image = FireGame_1Project.Properties.Resources.gif_spin;
        }

        private void shoot_click_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(FireGame_1Project.Properties.Resources.fire);
            obj.Play();

            shoot++;
            pictureBox1.Image = FireGame_1Project.Properties.Resources.gif_shoot;
            if (shoot!=4) {
                if (winner.winTest(shoot)==0) {
                    MessageBox.Show("Your lifes are finished and lose the game ");
                    shoot_click.Enabled = false;
                    play_again.Enabled = true;
                    flag++;
                }

            }
            if (shoot==4 && flag==0) {
                MessageBox.Show("Congrats you got 100 Marks and win the game ");
                shoot_click.Enabled = false;
                play_again.Enabled = true;
            }
        }

        private void play_again_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
