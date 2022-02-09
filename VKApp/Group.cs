using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKApp
{
    public class Group
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? screen_name { get; set; }
        public int is_closed { get; set; }
        public string? type { get; set; }
        public int is_admin { get; set; }
        public int is_member { get; set; }
        public int is_advertiser { get; set; }
        public string? photo_50 { get; set; }
        public string? photo_100 { get; set; }
        public string? photo_200 { get; set; }

        public override string? ToString()
        {
            return $@"id = {id} 
name = {name} 
screen_name = {screen_name} 
photo_200 = {photo_200}";
        }
    }
}
