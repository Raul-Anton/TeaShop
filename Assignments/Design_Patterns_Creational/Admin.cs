using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace Assignments.Design_Patterns_Creational
{
    public class Admin : User
    {
        private static object _myLock = new object();
        private static Admin _myAdmin = null;

        private Admin() { }

        public static Admin GetInstance()
        {
            if (_myAdmin is null)
            {
                lock (_myLock)
                {
                    if (_myAdmin is null)
                    {
                        _myAdmin = new Admin();
                    }
                }
            }
            return _myAdmin;
        }
    }
}
