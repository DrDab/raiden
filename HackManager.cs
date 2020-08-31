using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiden
{
    class HackManager
    {
        static public List<String> impostors;
        public enum Color
        {
            Red,
            Blue,
            Green,
            Pink,
            Orange,
            Yellow,
            Black,
            White,
            Purple,
            Brown,
            Cyan,
            Lime
        }

        static public void HandleLine(string line)
        {
            if (line == "" || line == null)
            {
                return;
            }
            switch (line[0])
            {
                case 'i':
                    if (line.Length > 2)
                    {
                        HandleReveal(line.Substring(2));
                    }
                    break;
                default:
                    break;
            }
        }

        static void HandleReveal(string data)
        {
            string[] colors_list = data.Split(null);
            impostors = new List<String>();
            foreach (string color_id_str in colors_list)
            {
                if (color_id_str == "")
                {
                    continue;
                }
                Color color = (Color)(int)(color_id_str[0] - '0');
                impostors.Add(color.ToString());
            }
            Program.client_form.UpdateImpostorsText();
        }
    }
}
