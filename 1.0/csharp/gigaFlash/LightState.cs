using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 

namespace gigaFlash
{
    public class LightState
    {
        #region Constructors 
        public LightState()
            : this(4) { }

        public LightState(int pNumberOfLights)
            : this(pNumberOfLights, new Connection()) { }

        public LightState(int pNumberOfLights, Connection pConnection)
        {
            mNumberOfLights = pNumberOfLights;
            mLights = new List<Light>();
            for (int i = 0; i < pNumberOfLights; i++)
            {
                Light l = new Light(255, 0, 0);
                mLights.Add(l); 
            }
            mConnection = pConnection; 
        }
        #endregion

        #region Helpers   
        /// <summary>
        /// This struct defines the appropriate header for the end packet. 
        /// </summary>
        struct PacketHdr
        {
            public ulong hdr1;
            public ushort hdr2;
            public ushort hdr3;
            public ulong hdr4;
            public byte hdr5;
            public ushort hdr6;
            public long hdr7;
            public byte hdr8;

            public PacketHdr(ulong p1, ushort p2, ushort p3, ulong p4, byte p5, ushort p6, long p7, byte p8)
            {
                hdr1 = p1;
                hdr2 = p2;
                hdr3 = p3;
                hdr4 = p4;
                hdr5 = p5;
                hdr6 = p6;
                hdr7 = p7;
                hdr8 = p8;
            }
        }

        byte[] GetPacketHeaderAsByteArray()
        {
            
            //PacketHdr p = new PacketHdr(0x4adc0104, 0x0001, 0x0101, 0, 0, 0, -1, 0);
            //IEnumerable<byte> rv =
            //    BitConverter.GetBytes(p.hdr1).Concat(
            //    BitConverter.GetBytes(p.hdr2)).Concat(
            //    BitConverter.GetBytes(p.hdr3)).Concat(
            //    BitConverter.GetBytes(p.hdr4)).Concat(
            //    BitConverter.GetBytes(p.hdr5)).Concat(
            //    BitConverter.GetBytes(p.hdr6)).Concat(
            //    BitConverter.GetBytes(p.hdr7)).Concat(
            //    BitConverter.GetBytes(p.hdr8));
            //byte[] returnArray = rv.ToArray<byte>();
            //return returnArray;
            byte[] h1 = BitConverter.GetBytes(0x4adc0104);
            byte[] h2 = BitConverter.GetBytes((ushort)0x0001);
            byte[] h3 = BitConverter.GetBytes((ushort)0x0101);
            byte[] h4 = new byte[4];
            byte[] h5 = new byte[1];
            byte[] h6 = new byte[2];
            byte[] h7 = BitConverter.GetBytes(-1);
            byte[] h8 = new byte[1];
            IEnumerable<byte> myBytes = h1.Concat(h2).Concat(h3).Concat(h4).Concat(h5).Concat(h6).Concat(h7).Concat(h8);
            return myBytes.ToArray(); 
        }
        #endregion 

        #region Public Methods
        public void Update()
        {
            //We need a byte array that has a slot for each color of for each light.
            byte[] lightArray = new byte[3 * mLights.Count];
            
            //Initialize the array based on the lights in our collection. 
            foreach (Light light in mLights) 
            {
                int addr = mLights.IndexOf(light);
                lightArray[addr] = (byte) light.Red;
                lightArray[addr + 1] = (byte) light.Green;
                lightArray[addr + 2] = (byte) light.Blue; 
            }

            IEnumerable<byte> outputList = GetPacketHeaderAsByteArray().Concat(lightArray);


            byte[] outString = outputList.ToArray<byte>(); 
            mConnection.Send(outString);             
            //'\x04\x01\xdcJ\x01\x00\x01\x01\x00\x00\x00\x00\x00\x00\x00\x00\xff\xff\xff\xff\x00\x80\x80\xff\xff\xff\x80\x00\x00\x00'
            //string hdr = "0x4adc0104, 0x0001, 0x0101, 0, 0, 0, -1, 0
        }
        #endregion

        #region Members / Properties
        protected int mNumberOfLights;

        protected Connection mConnection;

        protected List<Light> mLights;
        public List<Light> Lights
        {
            get { return mLights; }
            set { mLights = value; }
        }
        #endregion 
    }
}
