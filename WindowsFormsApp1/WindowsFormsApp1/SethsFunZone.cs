using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SethsFunZone
    {
        public int mathFun(int p_num1,int p_num2)
        {
            int m_num1, m_num2,m_num3;
            m_num1 = p_num1;
            m_num2 = p_num2;
            m_num3 = m_num1 * m_num2;
            m_num3 = m_num3 - (m_num1 + m_num2);
            m_num3 = m_num3 + m_num1;
            return (m_num3);
        }
    }
}
