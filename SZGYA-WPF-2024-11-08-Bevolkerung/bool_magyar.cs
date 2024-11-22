using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_2024_11_08_Bevolkerung
{
    public struct bool_magyar
    {
        private Boolean m_Value;


        private bool_magyar(Boolean value)
        {
            m_Value = value;
        }


        public static implicit operator bool_magyar(bool val)
        {
            bool_magyar magyar;
            magyar.m_Value = val;
            return magyar;

        }

        public static implicit operator bool(bool_magyar val)
        {
            return val.m_Value; 
        }

        public override bool Equals(object obj)
        {
            if (!(obj is bool_magyar))
                return false;

            bool_magyar other = (bool_magyar)obj;

            return other.m_Value == m_Value;
        }

        public override int GetHashCode()
        {
            return m_Value ? 1 : 0;
        }

        public Boolean ToBoolean()
        {
            return m_Value;
        }

        public override string ToString()
        {
            return this.m_Value ? "igen" : "nem";
        }
    }
}
