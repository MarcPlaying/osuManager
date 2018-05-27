using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_Manager_c
{
    class Config
    {
        // -----------------------------------------------
        // This is the GitHub version of osu!Manager 1.1.0
        // -----------------------------------------------
        // by MarcPlaying aka MarcUPlayOsu
        // -----------------------------------------------

        public static String osuAPIkey = "";
        // You will get this API Key on the osu! Site Link: https://osu.ppy.sh/p/api

        public static String localserv = "https://marc.enjuu.click/manager/nserv";

        public static String username = Environment.UserName;
        public static String mainDir = @"C:\Users\"+username+ @"\AppData\Roaming\osu!Manager";

        public static String SiteForBadges = "https://marc.enjuu.click/manager/badges/";
        // Webserver for the Badges

        public static String SiteForSkins = "https://marc.enjuu.click/manager/Skins.zip";
        // Zip File for Skin links

        public static String getvertxt = "https://marc.enjuu.click/manager/req/ver.txt";

        public static String siteforupadate = "https://new.ppy.sh/forum/p/6558824/";
    }
}
