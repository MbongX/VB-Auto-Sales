using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB_Auto_Sales.models
{
    class plug
    {
        private string vbBrand,Brand_A,Brand_B,Brand_C = "";
        public plug(string vb,string A, string B,string C) {
            this.vbBrand = vb;
            this.Brand_A = A;
            this.Brand_B = B;
            this.Brand_C = C;
        }
        plug() { }
        public string getVB_Brand() => this.vbBrand;
        public string getBrand_A() => this.Brand_A;
        public string getBrand_B() => this.Brand_B;
        public string getBrand_C() => this.Brand_C;
    }
}
