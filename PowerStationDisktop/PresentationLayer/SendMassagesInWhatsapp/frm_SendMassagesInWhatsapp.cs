using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Text.Json;


namespace PowerStationDisktop.PresentationLayer.SendMassagesInWhatsapp
{
    public partial class frm_SendMassagesInWhatsapp : Form
    {
        BusinessLayer.Areas.ClsAreas areas = new BusinessLayer.Areas.ClsAreas();
        BusinessLayer.SendMassagesInWhatsapp.ClsSendMassagesInWhatsapp sendMassagesInWhatsapp = new BusinessLayer.SendMassagesInWhatsapp.ClsSendMassagesInWhatsapp();
        private Regex regex = new Regex(@"^7[80137]\d{7}$");


        public frm_SendMassagesInWhatsapp()
        {
            InitializeComponent();
            GetAllAreas();

            
        }

        void GetAllAreas()
        {
            cmb_AreaName.DataSource = areas.GetAllAreas();

            cmb_AreaName.DisplayMember = "AreaName";
            cmb_AreaName.ValueMember = "AreaID";
        }

        private void chk_SendForAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SendForAll.Checked)
            {
                cmb_AreaName.Enabled = false;
            }

        }

        private void txt_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_PhoneNumber.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string input = txt_PhoneNumber.Text;
            if (!regex.IsMatch(input))
            {
                //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_PhoneNumber.BackColor = Color.Red;

                //txt_CustomerPhone.Clear();
            }
            else
            {
                txt_PhoneNumber.BackColor = Color.White;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MessageFormate = "\n\n عزيزي العميل: (اسم العميل) \n" +
                                     "فاتورة الكهرباء الخاصة بك بتاريخ ( تاريخ القراءة ) كانت كالتالي: \n\n" +
                                     "القراءة السابقة: (القراءة السابقة)\n" +
                                     "القراءة الحالية: (القراءة الحالية)\n" +
                                     "اجمالي الاستهلاك: (اجمالي الاستهلاك)\n" +
                                     "سعر الكيلو: (سعر الكيلو)\n" +
                                     "المتأخرات: (المتأخرات)\n" +
                                     "اجمالي الفاتورة: (اجمالي الفاتورة)\n\n" +
                                     "للدفع من خلال الموقع .. ادخل الرابط التالي: (رابط الدفع)\n";


            if (tabControl1.SelectedTab == tabPage2) // التحقق من أن التبويب النشط هو tabPage2
            {
                rich_MessageText.Text = MessageFormate;
                rich_MessageText.Enabled = false;
            }
            else if(tabControl1.SelectedTab == tabPage1)
            {
                rich_MessageText.Text = string.Empty;
                rich_MessageText.Enabled = true;
            }
        }


        class Customer
        {
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string CustomerPhoneNumber { get; set; }
            public string CustomerTotalDues { get; set; }
            public string PreviousReading { get; set; }
            public string CurrentReading { get; set; }
            public string DateOfCurrentReading { get; set; }    
            public string PriceOfKilo { get; set; }
            public string PowerStationWebsite { get; set; }
        }

        static string GenerateMessage(Customer customer)
        {

            double TotalOfPowerUsing = Convert.ToDouble(customer.CurrentReading) - Convert.ToDouble(customer.PreviousReading);
            double TotalBill = TotalOfPowerUsing * Convert.ToDouble(customer.PriceOfKilo);
            return $"\n\n عزيزي العميل: {customer.CustomerName} \n" +
                   $"فاتورة الكهرباء الخاصة بك بتاريخ ({customer.DateOfCurrentReading} ) كانت كالتالي: \n\n" +
                   $"القراءة السابقة: {customer.PreviousReading}\n" +
                   $"القراءة الحالية: {customer.CurrentReading}\n" +
                   $"اجمالي الاستهلاك: {TotalOfPowerUsing}\n" +
                   $"سعر الكيلو: {customer.PriceOfKilo}\n" +
                   $"المتأخرات: {customer.CustomerTotalDues}\n" +
                   $"اجمالي الفاتورة: {TotalBill}\n\n" +
                   $"للدفع من خلال الموقع .. ادخل الرابط التالي: {customer.PowerStationWebsite}\n";
        }


        List<Customer> GetAllCustomerInformationForSendingMessagesInWhatsapp()
        {
            List<Customer> customers = new List<Customer>();

            // استدعاء الدالة الخاصة بك لجلب بيانات العملاء
            DataTable dataTable1 = sendMassagesInWhatsapp.GetAllCustomerInformationForSendingMessagesInWhatsapp();

            foreach (DataRow row in dataTable1.Rows)
            {
                customers.Add(new Customer
                {
                    CustomerID = row["CustomerID"].ToString(),
                    CustomerName = row["CustomerName"].ToString(),
                    CustomerPhoneNumber = row["CustomerPhoneNumber"].ToString(),
                    CustomerTotalDues = row["CustomerTotalDues"].ToString(),
                    PreviousReading = row["PreviousReading"].ToString(),
                    CurrentReading = row["CurrentReading"].ToString(),
                    DateOfCurrentReading = row["DateOfCurrentReading"].ToString(),
                    PriceOfKilo = row["PriceOfKilo"].ToString(),
                    PowerStationWebsite = row["PowerStationWebsite"].ToString()
                });
            }

            return customers;
        }

        //  إرسال الرسالة عبر WhatsApp API
        static async Task SendWhatsAppMessage(string phoneNumber, string message)
        {
            string token = "YOUR_ACCESS_TOKEN"; // التوكن الخاص بك
            string whatsappApiUrl = "https://graph.facebook.com/v17.0/YOUR_PHONE_NUMBER_ID/messages";

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var requestBody = new
            {
                messaging_product = "whatsapp",
                to = phoneNumber,
                type = "text",
                text = new { body = message }
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(whatsappApiUrl, jsonContent);
            string responseText = await response.Content.ReadAsStringAsync();

            Console.WriteLine($" رسالة إلى {phoneNumber}: {responseText}");
        }
    

        private async void  btn_Send_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage2)
            {
                //  استرجاع بيانات العملاء    
                List<Customer> customers = GetAllCustomerInformationForSendingMessagesInWhatsapp();

                //  إرسال رسالة لكل عميل
                foreach (var customer in customers)
                {
                    string message = GenerateMessage(customer); // إنشاء رسالة مخصصة للعميل
                    await SendWhatsAppMessage(customer.CustomerPhoneNumber, message); // إرسال الرسالة
                }

                Console.WriteLine("تم إرسال الرسائل إلى جميع العملاء بنجاح!");
            }

        }
}
}
