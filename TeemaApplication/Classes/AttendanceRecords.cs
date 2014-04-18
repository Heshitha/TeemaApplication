using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealandAPI;

namespace TeemaApplication.Classes
{
    class AttendanceRecords
    {
        public bool GetAllRecordsFromDevice()
        {
            Device d = new ZDFinger();
            try
            {
                d.Communication = 2;
                if (d.OpenCommunication())
                {
                    List<Record> allRecords = d.GetAllRecords();
                    d.CloseCommunication();

                    
                }
            }
            catch (Exception ex)
            {

            }

            return true;
        }
    }
}
