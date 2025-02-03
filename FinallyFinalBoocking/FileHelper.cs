using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinallyFinalBoocking
{
    public class FilePathHelper
    {
        public static string GetFilePath(string fileName)
        {
            string[] possiblePaths = {
                Path.Combine(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB", fileName),
                Path.Combine(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB", fileName)
            };

            foreach (var path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

            return null;
        }
    }

}
