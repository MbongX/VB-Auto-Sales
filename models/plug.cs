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


        string getVB_Brand() => this.vbBrand;
        string getBrand_A() => this.Brand_A;
        string getBrand_B() => this.Brand_B;
        string getBrand_C() => this.Brand_C;

    }
}
