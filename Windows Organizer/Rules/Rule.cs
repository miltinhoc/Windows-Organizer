using System;

namespace Windows_Organizer
{
    public class Rule : IComparable
    {
        public string SearchDirectory { get; set; }
        public string TargetDirectory { get; set; }
        public string Extension { get; set; }
        public bool SearchTopOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return obj is Rule
                ? (
                    ((Rule)obj).Extension == Extension &&
                    ((Rule)obj).SearchDirectory == SearchDirectory &&
                    ((Rule)obj).TargetDirectory == TargetDirectory &&
                    ((Rule)obj).SearchTopOnly == SearchTopOnly
                ) ? 1 : 0
                : 0;
        }
    }
}
