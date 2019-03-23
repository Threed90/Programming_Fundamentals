using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.SoftUniKaraoke3
{
    class KaraokeMemers
    {
        public string[] Members { get; set; }
        public string[] AvailableSongs { get; set; }
        public bool IsEmpty
        {
            get
            {
                if (this.Members.Length == 0 || this.AvailableSongs.Length == 0)
                    return true;
                return false;
            }
        }


        public KaraokeMemers (string names, string songs)
        {
            Members = names.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            AvailableSongs = songs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
        }

        public bool IsValidParticapnt(string name, string song)
        {
            if(this.Members.Contains(name) && this.AvailableSongs.Contains(song))
            {
                return true;
            }
            return false;
        }

        //public static bool IsEmpty(KaraokeMemers members)
        //{
        //    if(members.AvailableSongs.Length == 0 || members.Members.Length == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
