using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.DevAV {
    public static class Logger {
        public static void Log(string message) {
#if !DXCORE3
            Xpf.DemoBase.Helpers.Logger.Log(message);
#endif
        }
    }
}
