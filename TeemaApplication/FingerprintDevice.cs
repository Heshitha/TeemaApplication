using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TeemaApplication.Classes;
using RealandAPI;

namespace TeemaApplication
{
    public partial class frmFingerprintDevice : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        
        public frmFingerprintDevice()
        {
            InitializeComponent();
        }

        private void frmFingerprintDevice_Load(object sender, EventArgs e)
        {
            fillDeviceDetailsGridView();
            fillCommunicationType(cmbANDDCommunicationType);
            fillCommunicationType(cmbEDDCommunicationType);
        }

        private void fillCommunicationType(ComboBox comboBox)
        {
            List<communicationType> lstComType = new List<communicationType>();
            communicationType comType01 = new communicationType
            {
                CommunicationValue = 1,
                CommunicationText = "TCP / IP"
            };
            lstComType.Add(comType01);
            communicationType comType02 = new communicationType
            {
                CommunicationValue = 2,
                CommunicationText = "USB"
            };
            lstComType.Add(comType02);

            comboBox.DisplayMember = "CommunicationText";
            comboBox.ValueMember = "CommunicationValue";
            comboBox.DataSource = lstComType;
        }

        private void fillDeviceDetailsGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("deviceID");
            dt.Columns.Add("name");
            dt.Columns.Add("comType");
            dt.Columns.Add("ipAddress");
            dt.Columns.Add("ipPort");
            dt.Columns.Add("password");

            foreach (FingerPrintDevice fpd in db.FingerPrintDevices)
            {
                string communicationType = fpd.CommunicationType.Value == 1 ? "TCP / IP" : "USB";
                dt.Rows.Add(fpd.DeviceID, fpd.DeviceName, communicationType, fpd.IPAddress, fpd.IPPort, fpd.Password);
            }

            gdvDeviceDetails.DataSource = dt;
        }

        private void gdvDeviceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int deviceID = Convert.ToInt32(gdvDeviceDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                FingerPrintDevice device = db.FingerPrintDevices.Where(de => de.DeviceID == deviceID).SingleOrDefault();

                txtEDDDeviceID.Text = device.DeviceID.ToString();
                txtEDDDeviceName.Text = device.DeviceName;
                cmbEDDCommunicationType.SelectedValue = device.CommunicationType.Value;
                txtEDDIpAddress.Text = device.IPAddress;
                txtEDDIpPort.Text = device.IPPort.ToString();
                txtEDDPassword.Text = device.Password.ToString();
            }
            catch (Exception)
            {
                ShowMessageBox.ShowError("Something when wrong while excecuting the command. Please try again with correct procedure");
            }
        }

        private void btnEDDDone_Click(object sender, EventArgs e)
        {
            try
            {
                int deviceID = Convert.ToInt32(txtEDDDeviceID.Text);
                FingerPrintDevice device = db.FingerPrintDevices.Where(de => de.DeviceID == deviceID).SingleOrDefault();

                device.DeviceName = txtEDDDeviceName.Text;
                device.CommunicationType = (int)cmbEDDCommunicationType.SelectedValue;
                device.IPAddress = validateIP(txtEDDIpAddress) ? txtEDDIpAddress.Text : "0.0.0.0";
                device.IPPort = Convert.ToInt32(txtEDDIpPort.Text);
                device.Password = Convert.ToInt32(txtEDDPassword.Text);
                device.ModifiedBy = 1;
                device.ModifiedDate = DateTime.Now;

                db.SubmitChanges();
                fillDeviceDetailsGridView();
                ShowMessageBox.ShowSuccess("Successfully Updated.");
            }
            catch (Exception)
            {
                ShowMessageBox.ShowError("Something when wrong while excecuting the command. Please try again with correct procedure");
            }
        }

        private bool validateIP(TextBox textBox)
        {
            string address = textBox.Text;
            string[] splitedAddr = address.Split('.');
            if (splitedAddr.Length == 4)
            {
                foreach (string str in splitedAddr)
                {
                    if (str.Trim().Length > 3)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnANDDTestDevice_Click(object sender, EventArgs e)
        {
            int communicationType = (int)cmbANDDCommunicationType.SelectedValue;
            string ipAddress = validateIP(txtANDDIpAddress) ? txtEDDIpAddress.Text : "0.0.0.0";
            int ipPort = Convert.ToInt32(txtANDDIpPort.Text);
            int password = Convert.ToInt32(txtANDDPassword.Text);

            TestDevice(communicationType, ipAddress, ipPort, password);
        }

        private static void TestDevice(int communicationType, string ipAddress, int ipPort, int password)
        {
            Device d = new ZDFinger();
            d.Communication = communicationType;
            d.IpAddress = ipAddress;
            d.IpPort = ipPort;
            d.Password = password;

            bool result = d.OpenCommunication();
            d.CloseCommunication();

            if (result)
            {
                ShowMessageBox.ShowSuccess("Test succeed.");
            }
            else
            {
                ShowMessageBox.ShowError("Error occured. Plese re check conectivity, Ip Address, Ip Port and Password.");
            }
        }

        private void btnEDDTestDevice_Click(object sender, EventArgs e)
        {
            int communicationType = (int)cmbEDDCommunicationType.SelectedValue;
            string ipAddress = validateIP(txtEDDIpAddress) ? txtEDDIpAddress.Text : "0.0.0.0";
            int ipPort = Convert.ToInt32(txtEDDIpPort.Text);
            int password = Convert.ToInt32(txtEDDPassword.Text);

            TestDevice(communicationType, ipAddress, ipPort, password);
        }

        private void btnANDDAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                FingerPrintDevice device = new FingerPrintDevice
                    {
                        DeviceName = txtANDDDeviceName.Text,
                        CommunicationType = (int)cmbANDDCommunicationType.SelectedValue,
                        IPAddress = validateIP(txtANDDIpAddress) ? txtANDDIpAddress.Text : "0.0.0.0",
                        IPPort = Convert.ToInt32(txtANDDIpPort.Text),
                        Password = Convert.ToInt32(txtANDDPassword.Text),
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedDate = DateTime.Now,
                    };

                db.FingerPrintDevices.InsertOnSubmit(device);
                db.SubmitChanges();
                fillDeviceDetailsGridView();
                ShowMessageBox.ShowSuccess("Successfully Added New Device.");

                txtANDDDeviceName.Text = string.Empty;
                txtANDDIpAddress.Text = string.Empty;
                txtANDDIpPort.Text = string.Empty;
                txtANDDPassword.Text = string.Empty;
            }
            catch (Exception)
            {
                ShowMessageBox.ShowError("Something when wrong while excecuting the command. Please try again with correct procedure");
            }

        }
    }

    public class communicationType
    {
        public int CommunicationValue { get; set; }
        public string CommunicationText { get; set; }
    }
}
