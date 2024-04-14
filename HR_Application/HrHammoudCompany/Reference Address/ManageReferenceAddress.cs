using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany.Reference_Address
{
    public partial class ManageReferenceAddress : Form
    {




        static DataTable dtallReferenceAddreses = new DataTable();
        static public ClsReferenceAddress _Address = new ClsReferenceAddress();


        public ManageReferenceAddress(int appid)
        {
            InitializeComponent();

            _Address.AppID = appid;
        }




        // DataTable _DtEditTable = dtallReferenceAddreses.DefaultView.ToTable(false, "ReferenceAddressID", "NameAsReferenceAddress", "Typeofknowledge", "PhoneAsReferenceAddress", "Address");


        private void ManageReferenceAddress_Load(object sender, EventArgs e)
        {
            dtallReferenceAddreses = _Address.GetAdressesByID();
                if (dtallReferenceAddreses != null)
            {
                dtallReferenceAddreses = dtallReferenceAddreses.DefaultView.ToTable(false, "ReferenceAddressID", "NameAsReferenceAddress", "Typeofknowledge", "PhoneAsReferenceAddress", "Address");
                dataGridView1.DataSource = dtallReferenceAddreses;
                LbNumber.Text = dtallReferenceAddreses.Rows.Count.ToString();

                dataGridView1.Columns[0].HeaderText = "رقم العنوان";
                dataGridView1.Columns[0].Width = 120;

                dataGridView1.Columns[1].HeaderText = "الإسم";
                dataGridView1.Columns[1].Width = 200;

                dataGridView1.Columns[2].HeaderText = "نوع المعرفة";
                dataGridView1.Columns[2].Width = 140;

                dataGridView1.Columns[3].HeaderText = "رقم الهاتف";
                dataGridView1.Columns[3].Width = 250;

                dataGridView1.Columns[4].HeaderText = "العنوان";
                dataGridView1.Columns[4].Width = 250;

            }


        }

        private void AddAddress()
        {
            //_Address.AppID = ApplicationID;


        }
        private void Clear()
        {
            NameReferenceAddress.Text = "";
            PhoneReferenceAddress.Text = "";
            KindKnwoledge.Text = "";
            AddressAsReference.Text = "";

        }
        private void AddReferenceAddress_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(NameReferenceAddress.Text.Trim()))
            {
                MessageBox.Show("يجب تعبئة خانة الإسم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrEmpty(PhoneReferenceAddress.Text.Trim()))
            {
                MessageBox.Show("يجب تعبئة خانة الهاتف ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
            DialogResult dr = MessageBox.Show("هل أنت متأكد من حذف هذا العنوان", "سؤال؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
            {
                return;
            }


            _Address.NameAsReferenceAddress = NameReferenceAddress.Text;
            _Address.PhoneAsReferenceAddress = PhoneReferenceAddress.Text;
            _Address.Typeofknowledge = KindKnwoledge.Text;
            _Address.Address = AddressAsReference.Text;

            if (_Address.AddNewAddress())
            {
                MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageReferenceAddress_Load(null, null);

                Clear();
                return;

            }
            else
            {
                MessageBox.Show(" فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NameReferenceAddress.Text.Trim()))
            {
                MessageBox.Show("يجب تعبئة خانة الإسم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (string.IsNullOrEmpty(PhoneReferenceAddress.Text.Trim()))
            {
                MessageBox.Show("يجب تعبئة خانة الهاتف ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            DialogResult dr = MessageBox.Show("هل أنت متأكد من حذف هذا العنوان", "سؤال؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
            {
                return;
            }



            _Address.ReferenceAddressID = ((int)dataGridView1.CurrentRow.Cells[0].Value);
            _Address.NameAsReferenceAddress = NameReferenceAddress.Text;
            _Address.PhoneAsReferenceAddress = PhoneReferenceAddress.Text;
            _Address.Typeofknowledge = KindKnwoledge.Text;
            _Address.Address = AddressAsReference.Text;


            if (_Address.UpdateAddress())
            {

                MessageBox.Show("تمت عملية التعديل بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageReferenceAddress_Load(null, null);
                Clear();
                return;

            }
            else
            {
                MessageBox.Show(" فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return;

            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل أنت متأكد من حذف هذا العنوان", "سؤال؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr!=DialogResult.Yes)
            {
                return;
            }

            if (ClsReferenceAddress.DeleteReferenceAddress(((int)dataGridView1.CurrentRow.Cells[0].Value)))
            {

                MessageBox.Show("تمت عملية الحذف بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageReferenceAddress_Load(null, null);
                Clear();
                return;

            }
            else
            {
                MessageBox.Show(" فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

