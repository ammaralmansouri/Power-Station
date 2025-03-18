using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace PowerStationDisktop.PresentationLayer.PowerStation
{
    public partial class frm_PowerStation : Form
    {
        BusinessLayer.PowerStation.ClsPowerStation powerStation = new BusinessLayer.PowerStation.ClsPowerStation();
        private Regex regex = new Regex(@"^7[80137]\d{7}$");

        public frm_PowerStation()
        {
            InitializeComponent();

            
            DataTable DataTable1 = powerStation.GetAllPowerStation();

            if (DataTable1.Rows.Count > 0)
            {
                txt_PowerStationID.Text = DataTable1.Rows[0][0].ToString();
                txt_PowerStationArabicName.Text = DataTable1.Rows[0][1].ToString();
                txt_PowerStationEnglishName.Text = DataTable1.Rows[0][2].ToString();
                txt_PowerStationEnglishAddress.Text = DataTable1.Rows[0][3].ToString();
                txt_PowerStationArabicAddress.Text = DataTable1.Rows[0][4].ToString();
                txt_PowerStationPhoneNumber.Text = DataTable1.Rows[0][5].ToString();
                txt_PowerStationEmail.Text = DataTable1.Rows[0][6].ToString();
                txt_PowerStationWebsite.Text = DataTable1.Rows[0][7].ToString();

                //how to shwe the image..
                byte[] BImage = (byte[])DataTable1.Rows[0][8];
                MemoryStream ms = new MemoryStream(BImage);
                pb_PowerStationLogo.Image = Image.FromStream(ms);

                btn_New.Enabled = false;
                btn_Save.Enabled = false;
            }
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "All file| *.gif;*.jpg;*.png;*.bmp";


            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_PowerStationLogo.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btn_DeleteImage_Click(object sender, EventArgs e)
        {
            pb_PowerStationLogo.Image = null;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls) //move for all controlles and check if they are textbox make this control empty and enable this control..
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                    ((TextBox)c).Enabled = true;

                }
            }

            btn_AddImage.Enabled = true;
            btn_Save.Enabled = true;
            btn_Edit.Enabled = false;

            txt_PowerStationArabicName.Focus();
        }

        private void txt_PowerStationEmail_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+$"); // this is how email should be writtrn
            if (!reg.IsMatch(txt_PowerStationEmail.Text))
            {
                MessageBox.Show("صيغة البريد الإلكتروني التي ادخلتها غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PowerStationEmail.Focus();
            }
        }

        private void txt_PowerStationWebsite_Validated(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(\w+\.)*\w+([-.]\w+)*\.\w+$"); // this is how email should be writtrn
            if (!reg.IsMatch(txt_PowerStationWebsite.Text))
            {
                MessageBox.Show("صيغة الموقع الإلكتروني التي ادخلتها غير صحيحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PowerStationWebsite.Focus();
            }
        }

        private void txt_PowerStationPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Prevent entering more than 9 characters
            if (txt_PowerStationPhoneNumber.Text.Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_PowerStationArabicName_Enter(object sender, EventArgs e)
        {
            //when we are in this filed the language will change to arabic automaticlly..
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));
        }

        private void txt_PowerStationEnglishName_Enter(object sender, EventArgs e)
        {
            //when we are in this filed the language will change to arabic automaticlly..
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txt_PowerStationArabicAddress_Enter(object sender, EventArgs e)
        {
            //when we are in this filed the language will change to arabic automaticlly..
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-ye"));
        }

        private void txt_PowerStationEnglishAddress_Enter(object sender, EventArgs e)
        {
            //when we are in this filed the language will change to arabic automaticlly..
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-us"));
        }

        private void txt_PowerStationPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string input = txt_PowerStationPhoneNumber.Text;
            if (!regex.IsMatch(input))
            {
                //MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_PowerStationPhoneNumber.BackColor = Color.Red;

                //txt_CustomerPhone.Clear();
            }
            else
            {
                txt_PowerStationPhoneNumber.BackColor = Color.White;
            }
        }

        private void txt_PowerStationPhoneNumber_Validated(object sender, EventArgs e)
        {
            string input = txt_PowerStationPhoneNumber.Text;
            if (!regex.IsMatch(input))
            {
                MessageBox.Show("لطفا ادخل رقم هاتف صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_PowerStationPhoneNumber.BackColor = Color.Red;
                txt_PowerStationPhoneNumber.Focus();


            }
            else
            {
                txt_PowerStationPhoneNumber.BackColor = Color.White;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            byte[] BImage;

            if (pb_PowerStationLogo.Image == null)
                MessageBox.Show("يجب عليك ادخال صورة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MemoryStream ms = new MemoryStream(); // Lcate space in memory to store image in it befor send it to database..
                pb_PowerStationLogo.Image.Save(ms, pb_PowerStationLogo.Image.RawFormat); // save in lacted space..
                BImage = ms.ToArray(); // image now stored as bytes

                powerStation.UpdatePowerStation(Convert.ToInt32(txt_PowerStationID.Text), txt_PowerStationArabicName.Text, txt_PowerStationEnglishName.Text, txt_PowerStationArabicAddress.Text, txt_PowerStationEnglishAddress.Text, txt_PowerStationPhoneNumber.Text, txt_PowerStationEmail.Text, txt_PowerStationWebsite.Text, BImage);

                MessageBox.Show("تمت عملية التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            byte[] BImage;
            if (pb_PowerStationLogo.Image == null)
                MessageBox.Show("يجب عليك ادخال صورة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MemoryStream ms = new MemoryStream(); // Lcate space in memory to store image in it befor send it to database..
                pb_PowerStationLogo.Image.Save(ms, pb_PowerStationLogo.Image.RawFormat); // save in lacted space..
                BImage = ms.ToArray(); // image now stored as bytes

                powerStation.AddPowerStation(txt_PowerStationArabicName.Text, txt_PowerStationEnglishName.Text, txt_PowerStationArabicAddress.Text, txt_PowerStationEnglishAddress.Text, txt_PowerStationPhoneNumber.Text, txt_PowerStationEmail.Text, txt_PowerStationWebsite.Text, BImage);

                MessageBox.Show("تمت عملية الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

            }
        }

       
    }
}
