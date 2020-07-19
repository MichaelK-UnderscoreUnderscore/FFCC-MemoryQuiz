using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCC_Memories
{
    class Memories
    {
        private int answer;
        private string image;
        private string[] buttons = new string[5];
        private bool[] modifier = new bool[5];

        public void setButton(int id, string str)
        {
            buttons[id] = str;
        }
        public void setModifier(int id, bool mod)
        {
            modifier[id] = mod;
        }
        public void setAnswer(int ans)
        {
            answer = ans;
        }
        public void setImage(string img)
        {
            image = img;
        }
        public string getButton(int id)
        {
            return buttons[id];
        }
        public bool getModifier(int id)
        {
            return modifier[id];
        }
        public int getAnswer()
        {
            return answer;
        }
        public string getImage()
        {
            return image;
        }
    }
}
