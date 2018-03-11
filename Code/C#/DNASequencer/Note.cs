using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNASequencer
{
    class Note
    {


        public TimeSpan abs_time { get; set; }
        public TimeSpan delta_time { get; set; }
        public int midinote { get; set; }
        public String allele { get; set; }

        public Note(long time, long delta, int note, String allele)
        {
            this.abs_time = new TimeSpan(0, 0, 0, 0, (int)(time / 10));
            this.delta_time = new TimeSpan(0, 0, 0, 0, (int)(delta / 10));
            this.allele = String.Copy(allele);
            this.midinote = note;

            if (delta_time.CompareTo(TimeSpan.Zero) < 0)
            {               
                MessageBox.Show("Whoa! delta timespan negative");
            }
        }        
    }
}
