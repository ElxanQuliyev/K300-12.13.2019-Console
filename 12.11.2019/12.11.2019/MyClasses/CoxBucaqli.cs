using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2019.MyClasses
{
    class CoxBucaqli
    {
        protected int teref;
        
        public CoxBucaqli(int tr)
        {
            teref = tr;
        }
        public virtual int Sahe()
        {
            return teref;
        }
    }
    class DordBucaqli : CoxBucaqli
    {
        public DordBucaqli(int dordteref):base(dordteref)
        {}
        public override int Sahe()
        {
            return teref * 4;
        }
    }
    class Ucbucaq:CoxBucaqli
    {
        public Ucbucaq(int ucteref):base(ucteref){}
        
        public override int  Sahe()
        {
            return teref*3;
        }
    }


}
