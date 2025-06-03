using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class frmManageCategories: Form
    {
        public frmManageCategories(List<string> Categories) {
            InitializeComponent();
            this.Categories = Categories;
        }

        public List<string> Categories = new List<string>();

        private void btnAddCategory_Click(object sender, EventArgs e) {
            if (txtCategoryName.Text == "") return;

            string categoryName = txtCategoryName.Text.Trim();
            ListViewItem item = new ListViewItem(categoryName);

            listView1.Items.Add(item);

            txtCategoryName.Clear();
            txtCategoryName.Focus();

            Categories.Add(categoryName);
        }

        private void btnEditCategory_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0) {
                ListViewItem item = listView1.SelectedItems[0];
                txtCategoryName.Text = item.Text;
                btnAddCategory.Visible = false;
                btnUpdateCategory.Visible = true;
                btnUpdateCategory.Tag = item.Text;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e) {
            if (txtCategoryName.Text == "") return;

            string categoryName = txtCategoryName.Text.Trim();

            foreach (string category in Categories) {
                if (category == btnUpdateCategory.Tag.ToString()) {
                    int index = Categories.IndexOf(category);
                    Categories[index] = categoryName;
                    break;
                }
            }

            ListViewItem editItem = listView1.FindItemWithText(btnUpdateCategory.Tag.ToString());
            if (editItem != null)
                editItem.Text = categoryName;

            txtCategoryName.Clear();
            txtCategoryName.Focus();

            btnUpdateCategory.Visible = false;
            btnAddCategory.Visible = true;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e) {
            if (listView1.Items.Count > 0) {
                Categories.Remove(listView1.SelectedItems[0].Text);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void frmManageCategories_Load(object sender, EventArgs e) {
            foreach (string category in Categories) {
                ListViewItem item = new ListViewItem(category);
                listView1.Items.Add(item);
            }
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text)) {
                e.Cancel = true;
                txtCategoryName.Focus();
                errorProvider1.SetError(txtCategoryName, "Task Name is required!");
            }else {
                e.Cancel = false;
                errorProvider1.SetError(txtCategoryName, "");
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmManageCategories_FormClosing(object sender, FormClosingEventArgs e) {
            this.Dispose();
        }
    }
}
