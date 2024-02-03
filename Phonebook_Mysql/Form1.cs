using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook_Mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phonebookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phonebookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phonebook);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonebook._phonebook' table. You can move, or remove it, as needed.
            //this.phonebookTableAdapter.Fill(this.phonebook._phonebook);
            this.phonebookTableAdapter.FillBy_Image(this.phonebook._phonebook);
            //-----------
            save_cancel_butt();

        }

        void save_cancel_butt()
        {
            this.save_butt.Enabled = false;
            this.cancel_butt.Enabled = false;
            //-------
            this.add_butt.Enabled = true;
            this.edit_butt.Enabled = true;
            this.del_butt.Enabled = true;
            //------
            this.groupBox1.Enabled = false;
            this.phonebookDataGridView.Enabled = true;
            this.phonebookBindingNavigator.Enabled = true;

        }
        void add_edit_del()
        {
            this.save_butt.Enabled = true;
            this.cancel_butt.Enabled = true;
            //-------
            this.add_butt.Enabled = false;
            this.edit_butt.Enabled = false;
            this.del_butt.Enabled = false;
            //------------
            this.groupBox1.Enabled = true;
            this.phonebookDataGridView.Enabled = false;
            this.phonebookBindingNavigator.Enabled = false;


        }

        private void add_butt_Click(object sender, EventArgs e)
        {
            add_edit_del();
            //------------------
            this.phonebookBindingSource.AddNew();
            //----------
            this.pictureBox1.Image = Phonebook_Mysql.Properties.Resources.no_image_png_2;
        }

        private void edit_butt_Click(object sender, EventArgs e)
        {
            int rc = this.phonebookBindingSource.Count;
           // int rc = this.phonebook._phonebook.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("No records to edit!!");
                return;
            }
            //-------------
            add_edit_del();
        }

        private void del_butt_Click(object sender, EventArgs e)
        {
            int rc = this.phonebookBindingSource.Count;
            if (rc == 0)
            {
                MessageBox.Show("No records to delete!!");
                return;
            }
            //-------------
            DialogResult dr = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            this.phonebookBindingSource.RemoveCurrent();
            //----------------
            add_edit_del();
            //------
            this.groupBox1.Enabled = false;
        }

        private void save_butt_Click(object sender, EventArgs e)
        {
            this.phonebookBindingSource.EndEdit();
            int r = this.phonebookTableAdapter.Update(this.phonebook._phonebook);
            if (r > 0)
            {
                //this.phonebookDataGridView.Refresh();
                //this.phonebookBindingSource.ResetCurrentItem();  //used to show last saved id
                //-------------
                MessageBox.Show("Data Saved!!! Count:" + r.ToString());

            }
            else
            {
                MessageBox.Show("Not Saved!! Try Again");
            }
            //-------------------
            save_cancel_butt();
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            save_cancel_butt();
            //----------
            this.phonebook._phonebook.RejectChanges();
            this.phonebookBindingSource.CancelEdit();

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void browse_button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn = this.openFileDialog1.FileName;
            //-------empty file guard---------
            if (fn == "openFileDialog1")
            {
                return;
            }
            this.pictureBox1.Image = Image.FromFile(fn);
        }

        private void phonebookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //=============================
        //=============================


    }
}
