using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface ILieutenantGeneral : IPrivate
    {
        List<Private> Privates { get; }

        void AddPrivate(Private privates);
    }
}
