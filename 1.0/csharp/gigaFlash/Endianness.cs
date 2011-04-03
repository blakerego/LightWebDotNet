using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash
{
    public class Endianness
    {
        /// from: http://nohero.blogsome.com/2006/09/06/little-endianbig-endian-under-c/

        #region unit
        /// <summary>
        /// Converts the given unsigned int to big endian. If the host machine is big endian no convertion is being performed.
        /// <summary>
        /// <param name="source">The unsigned int to convert.</param>
        /// <returns>The converted unsigned int.</returns>
        public static uint ToBigEndian(uint source)
        {
            if (BitConverter.IsLittleEndian)
            { return SwapEndianness(source); }
            return source;
        }

        public static uint ToLittleEndian(uint source)
        {
            if (!BitConverter.IsLittleEndian)
            { return SwapEndianness(source); }
            return source; 
        }

        public static uint SwapEndianness(uint source)
        {
            return (uint)(((source & 0x000000FF << 24)
               | ((source & 0x0000FF00) << 8)
               | ((source & 0x00FF0000) >> 8)
               | ((source & 0xFF000000) >> 24)));
        }
        #endregion

        #region ushort
        public static ushort ToBigEndian(ushort source)
        {
            if (BitConverter.IsLittleEndian)
            { return SwapEndianness(source); }
            return source; 
        }

        public static ushort ToLittleEndian(ushort source)
        {
            if (!BitConverter.IsLittleEndian)
            {
                return SwapEndianness(source); 
            }
            return source; 
        }

        /// <summary>
        /// Converts the given unsigned short to big endian. If the host machine is big endian no convertion is being performed.
        /// <summary>
        /// <param name="source">The unsigned short to convert.</param>
        /// <returns>The converted unsigned short.</returns>
        public static ushort SwapEndianness(ushort source)
        {             
            return (ushort)(source >> 8 | source << 8);
        }

        
        #endregion

        #region ulong 

        #endregion 
    }
}
