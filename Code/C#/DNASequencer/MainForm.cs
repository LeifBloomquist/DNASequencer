using Sanford.Multimedia.Midi;
using SchemaFactor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNASequencer
{
    //class SNP;

    public partial class MainForm : Form
    {
        List<Note> Sequence = new List<Note>();
        TimeSpan total_time = new TimeSpan(0, 0, 0, 0, 0);

        public MainForm()
        {
            InitializeComponent();
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            Sequence.Clear();

            // MIDI note values for the C Major Pentatonic Scale.
            byte[] pentatonic = { // C   D  E  G  A 
                              //  0,  2, 4, 7, 9,       // Octave 0
                              //  12,14,16,19,21,       // Octave 1
                              //  24,26,28,31,33,       // Octave 2
                                  36,38,40,43,45,       // Octave 3
                                  48,50,52,55,57,       // Octave 4
                                  60,62,64,67,69,       // Octave 5
                                  72,74,76,79,81,       // Octave 6
                                  84,86,88,91,93        // Octave 7
                              //  96,98,100,103,105,    // Octave 8
                              //  108,110,112,115,117,  // Octave 9
                              //  120,122,124,127,      // Octave 10
                               };

            int counter = 0;
            string line = "";
            long last_time = 0;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Equals("")) continue;  // Blank lines
                if (line.StartsWith("#")) continue;  // Comment

                String[] snp = line.Split('\t');

                try
                {
                    int chromo = Int32.Parse(snp[1]);
                    if (chromo != 2) continue; // Only Chromo 2 for now
                }
                catch (Exception)
                {
                    break; // On all parse errors
                }

                long time = Int32.Parse(snp[2]);
                String allele = snp[3];

                int note = -1;

                switch (allele)
                {
                    case "--": note = -1; break;  // Rest
                    case "AA": note = pentatonic[0];   break;
                    case "GG": note = pentatonic[1];   break;
                    case "CC": note = pentatonic[2];   break;
                    case "TT": note = pentatonic[3];   break;
                    case "AG": note = pentatonic[4];   break;
                    case "GT": note = pentatonic[5];   break;
                    case "CT": note = pentatonic[6];   break;
                    case "AC": note = pentatonic[7];   break;
                    case "CG": note = pentatonic[8];   break;
                    case "II": note = pentatonic[9];   break;
                    case "DD": note = pentatonic[10];  break;
                    case "DI": note = pentatonic[11];  break;
                    case "AT": note = pentatonic[12];  break;                       

                    default:
                        //System.Console.WriteLine("Unknown allele {0} at line {1}.", allele, counter);
                        continue;                        
                }

                long delta_time = time - last_time;
                Note n = new Note(time, delta_time, note, allele);
                last_time = time;

                Sequence.Add(n);

                counter++;
            }

            file.Close();

            // Always force first note time to 0
            Sequence.ElementAt(0).delta_time = TimeSpan.Zero;

            // Add up the times
            total_time = TimeSpan.Zero;

            foreach (Note n in Sequence)
            {
                total_time += n.delta_time;

                if (total_time.CompareTo(TimeSpan.Zero) < 0)
                {
                    //your timespan is negative
                    MessageBox.Show("Whoa! timespan negative");
                }
            }

            MessageBox.Show("Loaded " + counter + " lines.");
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => PlaybackThread(Sequence));
            thread.Start();
        }

        public static double Divide(TimeSpan dividend, TimeSpan divisor)
        {
            return (double) dividend.Ticks / (double) divisor.Ticks;
        }

        private void SafeUpdateGUI(long delay, double percent, String allele)
        {
            this.Invoke(new Action(() => 
            {
                try
                {
                    lNote.Text = delay.ToString();
                    lPercentage.Text = percent.ToString("0.00%");
                    lAllele.Text = allele;
                }
                catch (Exception)
                {
                    ;  // Fail silently, window closing
                }
            }));
        }

        private void PlaybackThread(List<Note> Sequence)
        {
            Thread.CurrentThread.Name = "Playback Thread";

            TimeSpan elapsed_time = TimeSpan.Zero;

            MIDIHandler midi = MIDIHandler.Instance;
            midi.InitializeMIDI("Generator");

            foreach (Note n in Sequence)
            {
                SafeUpdateGUI((long)n.abs_time.TotalMilliseconds, Divide(elapsed_time, total_time), n.allele);

                Thread.Sleep(n.delta_time);
                elapsed_time += n.delta_time;
                
                if (n.midinote >= 0)
                {
                   midi.SendMIDI(ChannelCommand.NoteOn, 0, n.midinote, 0x7F);                   
                   //midi.SendMIDI(ChannelCommand.NoteOff, 0, n.midinote, 0x7F);                    
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

