using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace CRUFLCrystalReportHelper
{
    [ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("B60E679E-623F-4A55-9AEB-345583856F91")]
    public interface ITerbilang
    {
        string TerbilangIndonesia(int nominal);
    }
}
