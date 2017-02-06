using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace ClienteXna.Model
{
    class Cliente : RealmObject
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
    }
}
