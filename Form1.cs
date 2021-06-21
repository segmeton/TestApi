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

            string timeNow = DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss");
            string filename = $"output-{timeNow}.mp3";

            string textTTS = "";

            string A_L = "-8st";
            string B_L = "-6st";
            string C = "-5st";
            string D = "-3st";
            string E = "-1st";
            // F = 0
            string G = "+2st";
            string A = "+4st";
            string B = "+6st";
            string C_T = "+7st";


            //textTTS = "<speak>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">I'll </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">hold </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">my </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">head </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">up </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">high</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + B_L + "\"> </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">look</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">ing</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">to </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">the </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">sky</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + B_L + "\"> </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">so </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">they </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">won't </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">see</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">all </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">the </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\">tears</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\">that </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">are </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\">in </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">my </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">eyes </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\"> </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">no </prosody>" +  
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">one </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">will </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">know</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\"> </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">i'm </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">go</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">ing</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">through</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">my </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">first</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\">lone</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">ly </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">night </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">with</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">out</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">you</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\"> </prosody>" +
            //    "</speak>";

            //textTTS = "<speak>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">I'll </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">hold </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">my </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">head </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">up </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">high</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + B_L + "\"> </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"50%\" pitch=\"" + C + "\">look</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">ing</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">to </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">the </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">sky</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + B_L + "\"> </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">so </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">they </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">won't </prosody>" +
            //    "<prosody rate=\"50%\" pitch=\"" + E + "\">see </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">all </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">the </prosody>" +
            //    "<prosody rate=\"50%\" pitch=\"" + A + "\">tears</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\">that </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">are </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\">in </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">my </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">eyes </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\"> </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">no </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">one </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">will </prosody>" +
            //    "<prosody rate=\"33%\" pitch=\"" + D + "\">know </prosody>" +
            //    "<break time = \"1s\"/>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">i'm </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\"> </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">go</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">ing</prosody>" +
            //    "<prosody rate=\"25%\" pitch=\"" + E + "\">through </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\">my </prosody>" +
            //    "<prosody rate=\"50%\" pitch=\"" + C + "\">first</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A + "\">lone</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + G + "\">ly </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + E + "\">night </prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + D + "\">with</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + A_L + "\">out</prosody>" +
            //    "<prosody rate=\"default\" pitch=\"" + C + "\"> </prosody>" +
            //    "<prosody rate=\"33%\" pitch=\"" + C + "\">you</prosody>" +
            //    "</speak>";


            /*
            textTTS = "<speak>" +
                "<prosody>The winner for image 1 is Her daily goal was to improve on yesterday.</prosody>" +
                "<prosody pitch=\"" + B_L +"\">The winner for image 1 is Her daily goal was to improve on yesterday.</prosody>" +
                "<prosody pitch=\"" + B + "\">The winner for image 1 is Her daily goal was to improve on yesterday.</prosody>" +
                "</speak>";
            */

            textTTS = "<speak>" + 
                "<prosody rate=\"default\" pitch=\"" + C + "\">C </prosody>" +
                "<prosody rate=\"default\" pitch=\"" + D + "\">D </prosody>" +
                "<prosody rate=\"default\" pitch=\"" + E + "\">E </prosody>" +
                "<prosody rate=\"default\">F </prosody>" +
                "<prosody rate=\"default\" pitch=\"" + G + "\">G </prosody>" +
                "<prosody rate=\"default\" pitch=\"" + A + "\">A </prosody>" +
                "<prosody rate=\"default\" pitch=\"" + B + "\">B </prosody>" +
                "<prosody rate=\"default\" pitch=\"" + C_T + "\">C </prosody>" +
                "</speak>";


            google.GenerateAudio(textTTS, filename);

           Application.Exit();
        }
    }
}
