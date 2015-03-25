using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUser
{
    public class User
    {
        public User(string userEmail)
        {
            if (userEmail == null)
                throw new ArgumentNullException();

            m_email = userEmail;
        }

        private string m_email;
    }
}
