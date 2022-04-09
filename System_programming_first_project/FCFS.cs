using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_programming_first_project
{
    internal class FCFS
    {
        private bool prioritetga_ega;
        private bool statik;
        private int protsessorlar_soni;
        private int[] vaqt;
        private int yadrolar_soni;
        private int jarayonlar_soni;
        private int[] talab_vaqti;
        private int[] kelish_vaqti;
        private int[] prioritet;

        public FCFS(bool prioritetga_ega,bool statik,int protsessorlar_soni,
            int [] vaqt,int yadrolar_soni,int jarayonlar_soni,
            int [] talab_vaqti,int [] kelish_vaqti,int []prioritet)
        {
            
        }

        public FCFS(bool prioritetga_ega,bool haydab_chiqaruvchi, int protsessorlar_soni,
            int[] vaqt, string algoritm, int yadrolar_soni, int jarayonlar_soni,
            int[] talab_vaqti, int[] kelish_vaqti)
        {

        }

        private List<List<char>> jarayonlar_boshqaruvi()
        {
            List<List<char>> jarayonlar_x = new List<List<char>>();            
            
            for(int i=0;i<jarayonlar_soni;i++)
            {
                List<char> jarayonlarx = new List<char>();
                jarayonlar_x.Add(jarayonlarx);
            }

            bool talab_tugadi = true;
            for (int i=0;talab_tugadi;i++)
            {
                bool vaqt_keldi=false;
                for(int j=0;j<jarayonlar_soni;j++)
                {
                    vaqt_keldi = vaqt_keldi || kelish_vaqti[j] == i;
                }
                if (!vaqt_keldi)
                {
                    for (int j = 0; j < jarayonlar_soni; j++)
                    {
                        jarayonlar_x.ElementAt(i).Add(' ');
                    }
                    continue;
                }
                    
                else
                {
                    talab_tugadi = false;

                    for (int j = 0; j < jarayonlar_soni; j++)
                        talab_tugadi = talab_tugadi || talab_vaqti[j] != 0;

                    if (talab_tugadi)
                    {
                        //Prioritetga ega bo'lgan holat
                        if (prioritetga_ega)
                        {
                            if (statik)
                            {
                                int min_vaqt = kelish_vaqti[0];
                                int prior = prioritet[0];
                                int index = 0;
                                for (int j = 1; j < jarayonlar_soni; j++)
                                {
                                    if (kelish_vaqti[j] < min_vaqt)
                                    {
                                        min_vaqt = kelish_vaqti[j];
                                        prior = prioritet[j];
                                        index = j;
                                    }

                                    else if (kelish_vaqti[j] == min_vaqt)
                                    {
                                        if (prioritet[j] <= prior)
                                        {
                                            prior = prioritet[j];
                                            index = j;
                                        }
                                    }
                                }


                            }

                            else
                            {

                            }
                        }

                        else
                        {

                        }
                    }
                
                    else
                        break;
                }
            }

            return jarayonlar_x;
        }
    }
}
