using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCAN.CLASS
{
    class M_Nilai
    {
        private String IDnilai;
        private String jenis;
        private float bobot;
        private float persentase;

        public void setJenis(String jenis)
        {
            this.jenis = jenis;
        }

        public String getJenis()
        {
            return this.jenis;
        }

        public void setPersentase(float nilai)
        {
            this.persentase = nilai;
        }

        public float getPersentase()
        {
            return this.persentase;
        }

        public void setBobot(float bobot)
        {
            this.bobot = bobot;
        }

        public float getBobot()
        {
            return this.bobot;
        }
    }
}
