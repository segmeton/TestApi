using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAPI
{
    public partial class Form1 : Form
    {
        private GoogleTest google;

        public Form1()
        {
            InitializeComponent();
            google = new GoogleTest();
            google.GenerateAudio("Welcome to Japan, the land of rising sun!!", "output-wavenet.mp3");
        }
    }
}
