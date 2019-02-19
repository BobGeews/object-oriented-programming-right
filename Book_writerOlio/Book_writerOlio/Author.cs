using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjallisuus
{
    class Author
    {
        public string name;
        public string birthday;

        public Author()
        {
            this.name = "";
            this.birthday = "";
        }
        public Author(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

    }
}
