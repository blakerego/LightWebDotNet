using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gigaFlash.Mainform;
using gigaFlash.Delegates;
using System.Management;
using System.IO;
using NAudio.Wave;
using System.Media;

namespace GigaFlashWinform
{
    public partial class MainFormView : BaseForm, IMainformView
    {
        #region Constructor 
        public MainFormView()
        {
            InitializeComponent();
        }
        #endregion 

        #region Members / Properties
        public FlowLayoutPanel FlowLayoutPanel
        {
            get { return mFlowLayoutPanel; } 
        }

        public Control Control
        {
            get
            {
                return this;
            }
        }

        public event VoidDelegate LightSelectorClicked;

        public event VoidDelegate SnakeModuleClicked;

        public event VoidDelegate AmpSineClicked;

        public event VoidDelegate ThunderClicked;

        #endregion

        #region Handlers
        private void HandleLightSelectorClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(LightSelectorClicked);
        }
        #endregion 

        private void HandleSnakeModuleClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(SnakeModuleClicked); 
        }

        private void mAmpSineButton_Click(object sender, EventArgs e)
        {
            EventUtils.FireEvent(AmpSineClicked); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadAudio(); 
        }

        private void mThunderButton_Click(object sender, EventArgs e)
        {
            EventUtils.FireEvent(ThunderClicked); 
        }

        private void WhatIsAcmDriver()
        {
            StringBuilder s = new StringBuilder();
            ManagementObjectSearcher mo = new ManagementObjectSearcher("select * from Win32_SoundDevice");

            foreach (ManagementObject soundDevice in mo.Get())
            {
                s.Append(soundDevice.GetPropertyValue("DeviceId") + "\n\n\n");
                s.Append(soundDevice.GetPropertyValue("Manufacturer"));
                // etc                       
            } MessageBox.Show(s.ToString());
        }

        private void ReadAudio()
        {
            SoundPlayer simpleSound = new SoundPlayer("C:\\svn\\batcave\\abslabs\\wav\\Dura.wav");

            simpleSound.Play();
            //Stream s =  simpleSound.Stream;

            /*
            using (var ms = File.OpenRead("C:\\svn\\batcave\\abslabs\\wav\\Dura.wav"))
            {
                using (var rdr = new WaveFileReader(ms))
                {
                    int steps = 100;
                    int stepSize = (int)rdr.Length / steps;

                    byte[][] audData = new byte[steps][];


                    for (int i = 0; i < 10; i++)
                    {
                        audData[i] = new byte[stepSize];
                        rdr.Read(audData[i], 0, stepSize);
                    }
                }
            }
             */
        }


    }
}
