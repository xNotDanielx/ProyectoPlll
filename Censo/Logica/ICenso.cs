﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICenso<T>
    {
        void Refresh();
        List<T> GetAll();
        String Añadir(T Sector);
    }
}
