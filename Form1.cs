using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RandomSound
{
    public partial class Form1 : Form
    {
        IntPtr hMidi;
        public Form1()
        {
            InitializeComponent();
            this.trackBar1.Value = this.volume;
            textbox_reset();

            winmm.midiOutOpen(out hMidi, -1, null, 0, CALLBACK.NULL);
            winmm.midiOutShortMsg(hMidi, 0xc, 0, GMProgram.AcousticGrandPiano, 40);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.playing = false;
            winmm.midiOutReset(hMidi);
            winmm.midiOutClose(hMidi);
        }

        byte volume = 60;
        byte note1 = 0x35;
        byte note2 = 0x55;
        byte sigma1 = 10;
        byte sigma2 = 10;
        double prob1 = 0.15;
        double prob2 = 0.05;

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.volume = (byte)this.trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbox_reset();
        }
        private void textbox_reset()
        {
            this.note1_textBox.Text = this.note1.ToString();
            this.note2_textBox.Text = this.note2.ToString();
            this.sgm1_textBox.Text = this.sigma1.ToString();
            this.sgm2_textBox.Text = this.sigma2.ToString();
            this.prob1_textBox.Text = this.prob1.ToString();
            this.prob2_textBox.Text = this.prob2.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.note1 = byte.Parse(this.note1_textBox.Text);
            this.note2 = byte.Parse(this.note2_textBox.Text);
            this.sigma1 = byte.Parse(this.note1_textBox.Text);
            this.sigma2 = byte.Parse(this.sgm2_textBox.Text);
            this.prob1 = double.Parse(this.prob1_textBox.Text);
            this.prob2 = double.Parse(this.prob2_textBox.Text);
        }

        bool playing = false;
        Thread midiplaythread;
        private void button1_Click(object sender, EventArgs e)
        {
            if (playing = !playing)
            {
                this.button1.Text = "stop";
                midiplaythread = new Thread(midiplay);
                midiplaythread.Start();
            }
            else
            {
                //this.midiplaythread.Abort();
                this.button1.Text = "play";

            }
        }


        static Random rand = new Random();
        void midiplay()
        {
            double alpha, beta;
            while (playing)
            {
                alpha = rand.NextDouble();
                beta = rand.NextDouble();
                var diff2 = Math.Sqrt(-2 * Math.Log(alpha));
                var diff1 = diff2 * Math.Cos(2 * Math.PI * beta);
                diff2 *= Math.Sin(2 * Math.PI * beta);
                if (rand.NextDouble() < this.prob1)
                    winmm.midiOutShortMsg(hMidi, 0x9, 0, (byte)(note1 + 12 * diff1), volume);
                if (rand.NextDouble() < this.prob2)
                    winmm.midiOutShortMsg(hMidi, 0x9, 0, (byte)(note2 + 12 * diff2), volume);

                Thread.Sleep(100);
            }
        }



    }
}
