using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.ConfigObjects
{
    public class UserPrefObj
    {
        public string Username;

        public string DateLastModfied;

        public string DateCreated;

        public List<ColorConfig> Colors;

        public List<RoomConfig> RoomConfigs; 
    }
}
