using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonPushGame {
    public partial class Form1 : Form {
        public Timer timer = new Timer();
        int currentScore;
        int wrongScore;
        int finalScore;
        Random rand;
        public int count = 0;
        public Form1() {
            InitializeComponent();
            this.label1.Text = "Total Count: " + Convert.ToString( 20 - count );
            this.label2.Text = "Score: 0";
            this.label3.Text = "Wrong Click: 0";
            this.label4.Text = "Final Score: 0";
            timer.Tick += new EventHandler( timer_Tick );
            this.count = 0;
            rand = new Random();
            makeButtonEnabled( false );
            this.currentScore = 0;
            this.wrongScore = 0;
            this.finalScore = this.currentScore + this.wrongScore;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button7_Click(object sender, EventArgs e) {
            makeButtonEnabled( true );
            timer.Enabled = true;
            timer.Start();
        }

        void makeButtonColorBlack( ) {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
        }

        void makeButtonEnabled( bool option ) {
            button1.Enabled = option;
            button2.Enabled = option;
            button3.Enabled = option;
            button4.Enabled = option;
            button4.Enabled = option;
            button5.Enabled = option;
            button6.Enabled = option;
        }

        void printScores( ) {
            this.label2.Text = "Score: " + Convert.ToString(currentScore);
            this.label3.Text = "Wrong Click: " + Convert.ToString(wrongScore);
            this.label4.Text = "Final Score: " + Convert.ToString(currentScore-wrongScore);
        }

        void timer_Tick( object sender, EventArgs e ) {
            if( count >= 20 ) {
                timer.Stop();
                timer.Enabled = false;
                makeButtonColorBlack( );
                makeButtonEnabled( false );
            }
            else {
                count++;
                this.label1.Text = "Total Count: " + Convert.ToString( 20 - count );
                int button = rand.Next(1, 6);
                if( button == 1 ) {
                    makeButtonEnabled( true );
                    makeButtonColorBlack();
                    button1.BackColor = Color.Red;
                }
                else if( button == 2 ) {
                    makeButtonEnabled( true );
                    makeButtonColorBlack();
                    button2.BackColor = Color.Red;
                }
                else if( button == 3 ) {
                    makeButtonEnabled( true );
                    makeButtonColorBlack();
                    button3.BackColor = Color.Red;
                }
                else if( button == 4 ) {
                    makeButtonEnabled( true );
                    makeButtonColorBlack();
                    button4.BackColor = Color.Red;
                }
                else if( button == 5 ) {
                    makeButtonEnabled( true );
                    makeButtonColorBlack();
                    button5.BackColor = Color.Red;
                }
                else if( button == 6 ) {
                    makeButtonEnabled( true );
                    makeButtonColorBlack();
                    button6.BackColor = Color.Red;
                }
                timer.Interval = 1500;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            makeButtonEnabled( false );
            if( button1.BackColor == Color.Red ) currentScore++;
            else wrongScore++;
            printScores();
        }

        private void button2_Click(object sender, EventArgs e) {
            makeButtonEnabled( false );
            if( button2.BackColor == Color.Red ) currentScore++;
            else wrongScore++;
            printScores();
        }

        private void button3_Click(object sender, EventArgs e) {
            makeButtonEnabled( false );
            if( button3.BackColor == Color.Red ) currentScore++;
            else wrongScore++;
            printScores();
        }

        private void button4_Click(object sender, EventArgs e) {
            makeButtonEnabled( false );
            if( button4.BackColor == Color.Red ) currentScore++;
            else wrongScore++;
            printScores();
        }

        private void button5_Click(object sender, EventArgs e) {
            makeButtonEnabled( false );
            if( button5.BackColor == Color.Red ) currentScore++;
            else wrongScore++;
            printScores();
        }

        private void button6_Click(object sender, EventArgs e) {
            makeButtonEnabled( false );
            if( button6.BackColor == Color.Red ) currentScore++;
            else wrongScore++;
            printScores();
        }

        private void button8_Click(object sender, EventArgs e) {
            makeButtonEnabled(true);
            makeButtonColorBlack();
            currentScore = 0; wrongScore = 0;
            printScores();
            count = 0;
            this.label1.Text = "Total Count: " + Convert.ToString( 20 - count );
            timer.Stop();
            timer.Enabled = false;
        }
    }
}
