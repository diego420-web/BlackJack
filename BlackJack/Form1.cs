using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int pontos = 0, pontosy = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            Random sorteio = new Random();

            x = sorteio.Next(1, 13);

            switch (x)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.a;
                    
                    pontos += 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    
                    pontos += 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    
                    pontos += 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    
                    pontos += 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                   
                    pontos += 5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    
                    pontos += 6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                   
                    pontos += 7;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                   
                    pontos += 8;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                   
                    pontos += 9;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    
                    pontos += 10;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.J;
                   
                    pontos += 11;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.Q;
                    
                    pontos += 12;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.K;
                   
                    break;
            }
            
            if (pontos <= 21)
            {
                lbl_pontos.Text = Convert.ToString(pontos);
                if (pontos == 21)
                {

                    //lbl_result.Text = "JOGADOR 1 GANHOU !";
                    button1.Enabled = false;
                    
                    button3.Enabled = true;
                }
            }
            else
            {
                //lbl_result.Text = "JOGADOR 1 PERDEU ! (" + Convert.ToString(pontos) + ")" ;
                button1.Enabled = false;
                
                button3.Enabled = true;
            }
            
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            int y;
            Random sorteio = new Random();

            y = sorteio.Next(1, 13);

            switch (y)
            {

                case 1:
                   
                    pictureBox2.Image = Properties.Resources.a;
                    pontosy += 1;
                    break;
                case 2:
                    
                    pictureBox2.Image = Properties.Resources._2;
                    pontosy += 2;
                    break;
                case 3:
                   
                    pictureBox2.Image = Properties.Resources._3;
                    pontosy += 3;
                    break;
                case 4:
                   
                    pictureBox2.Image = Properties.Resources._4;
                    pontosy += 4;
                    break;
                case 5:
                    
                    pictureBox2.Image = Properties.Resources._5;
                    pontosy += 5;
                    break;
                case 6:
                    
                    pictureBox2.Image = Properties.Resources._6;
                    pontosy += 6;
                    break;
                case 7:
                   
                    pictureBox2.Image = Properties.Resources._7;
                    pontosy += 7;
                    break;
                case 8:
                   
                    pictureBox2.Image = Properties.Resources._8;
                    pontosy += 8;
                    break;
                case 9:
                   
                    pictureBox2.Image = Properties.Resources._9;
                    pontosy += 9;
                    break;
                case 10:
                   
                    pictureBox2.Image = Properties.Resources._10;
                    pontosy += 10;
                    break;
                case 11:
                   
                    pictureBox2.Image = Properties.Resources.J;
                    pontosy += 11;
                    break;
                case 12:
                    
                    pictureBox2.Image = Properties.Resources.Q;
                    pontosy += 12;
                    break;
                case 13:
                    
                    pictureBox2.Image = Properties.Resources.K;
                    break;
            }
            
            if (pontosy <= 21)
            {
                label3.Text = Convert.ToString(pontosy);
                if (pontosy == 21)
                {

                    //lbl_result.Text = "JOGADOR 2 GANHOU !";
                    button3.Enabled = false;
                    button2.Enabled = true;
                    button1.Enabled = false;
                    resultados();
                }
            }
            else
            {
                //lbl_result.Text = "JOGADOR 2 PERDEU ! (" + Convert.ToString(pontosy) + ")";
                button3.Enabled = false;
                button2.Enabled = true;
                resultados();
            }

        }
        public void resultados()
        {
            if (pontos == 21)
                lbl_result.Text = "JOGADOR 1 GANHOU";
            else
                if (pontosy == 21)
                lbl_result.Text = "JOGADOR 2 GANHOU";
            else
                if (pontos == 21 && pontosy == 21)
                lbl_result.Text = "EMPATE";
            else
                lbl_result.Text = "SEM VENCEDOR";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_pontos.Text = "0";
            lbl_result.Text = " ";
            label3.Text = "0";
            pontos = 0;
            pontosy = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            pictureBox1.Image = Properties.Resources._0;
            pictureBox2.Image = Properties.Resources._0;

        }

        private void lbl_pontos_Click(object sender, EventArgs e)
        {

        }
    }
}
