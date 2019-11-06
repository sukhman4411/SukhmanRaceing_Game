using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SukhmanRaceing_Game
{
    // here we have use the concept of single level inheritance in whcih we load the random generation function 
    public class Ground : generateNo
    {
        //global variable to load the details 
        int Sukhman = 190, Harman = 200, Himakshi = 210;
        //method to print the result 
        public void victory(CheckedListBox cb, int car)
        {
            for (int y = 0; y < cb.Items.Count; y++)
            {

                if (cb.GetItemChecked(y))
                {
                    String h = cb.Items[y].ToString().Substring(0, cb.Items[y].ToString().IndexOf(' '));
                    String[] array = cb.Items[y].ToString().Split(' ');
                    if (h.Equals("Sukhman")) {
                        if (Convert.ToInt32(array[2]) == car)
                        {
                            Sukhman = (  Sukhman+ Convert.ToInt32(array[6]));
                            cb.Items[y] = "Sukhman has Dollar " + Sukhman;
                        }
                        else {
                            Sukhman = (Sukhman - Convert.ToInt32(array[6]));
                            cb.Items[y] = "Sukhman has Dollar " + Sukhman;
                        }


                    } else if (h.Equals("Harman")) {
                        if (Convert.ToInt32(array[2]) == car)
                        {
                            Harman = (Harman+Convert.ToInt32(array[6]));
                            cb.Items[y] = "Harman has Dollar " + Harman;
                        }
                        else
                        {
                            Harman = (Harman - Convert.ToInt32(array[6]));
                            cb.Items[y] = "Harman has Dollar " + Harman;
                        }

                    }
                    else if (h.Equals("Himakshi")) {
                        if (Convert.ToInt32(array[2]) == car)
                        {
                            Himakshi = (Himakshi+Convert.ToInt32(array[6]));
                            cb.Items[y] = "Himakshi has Dollar " + Himakshi;
                        }
                        else
                        {
                            Himakshi = (Himakshi - Convert.ToInt32(array[6]));
                            cb.Items[y] = "Himakshi has Dollar " + Himakshi;
                        }

                    }
                    cb.SetItemChecked(y, false);
                    
                }
            }

        }
    }
}
