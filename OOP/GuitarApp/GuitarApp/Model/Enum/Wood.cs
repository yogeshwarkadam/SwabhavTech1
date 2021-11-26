using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model.Enum
{
    public enum Wood
    {
        [Description("Indian Rosewood")] Indian_Rosewood,
        [Description("Brazilian Rosewood")] Brazilian_Rosewood,
        MAHOGANY, MAPLE,
        COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA
    }
}
