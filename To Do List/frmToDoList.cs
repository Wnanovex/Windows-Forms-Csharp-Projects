using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static To_Do_List.frmToDoList;

namespace To_Do_List
{
    public partial class frmToDoList: Form
    {
        public frmToDoList() {
            InitializeComponent();
            cbFilter.SelectedItem = cbFilter.Items[0];
            cbCategory.SelectedItem = cbCategory.Items[0];
        }

        public class Task {
            public string TaskName;
            public string Category;
            public DateTime CreatedDate;
            public DateTime PromisedDate;
            public bool isCompleted;

            public Task(string taskName, string category, DateTime createdDate, DateTime promisedDate) {
                TaskName = taskName;
                Category = category;
                CreatedDate = createdDate;
                PromisedDate = promisedDate;
            }
        }

        public List<Task> Tasks = new List<Task>();
        public List<string> Categories = new List<string>();

        private void LoadTasksIntoListView(System.Windows.Forms.ListView listView, List<Task> tasks) {
            listView.Items.Clear();
            foreach (var task in tasks) {
                ListViewItem item = new ListViewItem(task.TaskName.Trim());
                item.SubItems.Add(task.Category.Trim());
                item.SubItems.Add(task.CreatedDate.ToString());
                item.SubItems.Add(task.PromisedDate.ToString());
                item.Checked = task.isCompleted;
                item.SubItems.Add(task.isCompleted ? "Completed" : "Pending");
                listView.Items.Add(item);
            }
        }

        private void HandleFilter() {
            List<Task> filteredTasks;

            switch (cbFilter.SelectedItem.ToString()) {
                case "Completed":
                    tabControl1.SelectedTab.Text = "Completed";
                    filteredTasks = Tasks.Where(task => task.isCompleted).ToList();
                    break;
                case "Pending":
                    tabControl1.SelectedTab.Text = "Pending";
                    filteredTasks = Tasks.Where(task => !task.isCompleted).ToList();
                    break;
                default:
                    tabControl1.SelectedTab.Text = "All";
                    filteredTasks = Tasks;
                    break;
            }

            LoadTasksIntoListView(listView1, filteredTasks);
        }

        private void FilterByCategory() {
            List<Task> filteredTasks;

            TabPage selectedTab = tabControl1.SelectedTab;
            System.Windows.Forms.ListView listView = selectedTab.Controls[0] as System.Windows.Forms.ListView;

            if (selectedTab.Text == tabControl1.TabPages[0].Text)
                filteredTasks = Tasks;
            else
                filteredTasks = Tasks.Where(task => task.Category == selectedTab.Text).ToList();
            
            LoadTasksIntoListView(listView, filteredTasks);
        }

        private void CreateCategoryTabs() {
            TabPage allTab = tabControl1.TabPages[0];
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(allTab);

            cbCategory.Items.Clear();
            cbCategory.Items.Add("All");
            cbCategory.SelectedItem = cbCategory.Items[0];

            foreach (var category in Categories) {
                TabPage newTab = new TabPage(category);
                newTab.Name = category;

                // Create a ListView to hold tasks under the current category
                System.Windows.Forms.ListView listView = new System.Windows.Forms.ListView();
                listView.Dock = DockStyle.Fill;
                listView.View = View.Details;
                listView.CheckBoxes = true;
                listView.ItemChecked += listView1_ItemChecked;
                listView.Columns.Add("Task Name").Width = 237;
                listView.Columns.Add("Category").Width = 147;
                listView.Columns.Add("Created Date").Width = 202;
                listView.Columns.Add("Promised Date").Width = 204;
                listView.Columns.Add("Status").Width = 120;

                // Add the ListView to the tab page
                newTab.Controls.Add(listView);

                // Add the tab page to the TabControl
                tabControl1.TabPages.Add(newTab);

                cbCategory.Items.Add(category);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e) {
            if (txtTaskName.Text == "") return;

            Task NewTask = new Task(txtTaskName.Text, cbCategory.Text, DateTime.Now, dtPickerPromisedDate.Value);
            Tasks.Add(NewTask);

            FilterByCategory();

            txtTaskName.Clear();
            dtPickerPromisedDate.Value = DateTime.Now;
            cbCategory.SelectedItem = cbCategory.Items[0];
            txtTaskName.Focus();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e) {
            ListViewItem item = e.Item;
            foreach (Task task in Tasks) {
                if (task.TaskName == item.Text) {
                    if (item.Checked) {
                        item.SubItems[4].Text = "Completed";
                        task.isCompleted = true;
                    }else {
                        item.SubItems[4].Text = "Pending";
                        task.isCompleted = false;
                    }
                    break;
                }
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e) {
            System.Windows.Forms.ListView listViewOfCurrentTab = tabControl1.SelectedTab.Controls[0] as System.Windows.Forms.ListView;
            if (listViewOfCurrentTab.SelectedItems.Count > 0) {
                ListViewItem item = listViewOfCurrentTab.SelectedItems[0];
                txtTaskName.Text = item.Text;
                dtPickerPromisedDate.Text = item.SubItems[3].Text;
                cbCategory.SelectedValue = item.SubItems[1].Text;
                btnAddTask.Visible = false;
                btnUpdateTask.Visible = true;
                btnUpdateTask.Tag = item.Text;
            }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e) {
            if (txtTaskName.Text == "") return;

            Task updatedTask = new Task(txtTaskName.Text, cbCategory.Text, DateTime.Now, dtPickerPromisedDate.Value);

            foreach (Task task in Tasks) {
                if (task.TaskName == btnUpdateTask.Tag.ToString()) {
                    int index = Tasks.IndexOf(task);
                    Tasks[index] = updatedTask;  // Replacing the entire task at the given index.
                    break;
                }
            }

            FilterByCategory();

            txtTaskName.Clear();
            dtPickerPromisedDate.Value = DateTime.Now;
            cbCategory.SelectedItem = cbCategory.Items[0];
            txtTaskName.Focus();

            btnUpdateTask.Visible = false;
            btnAddTask.Visible = true;
        }

        private void btnDeleteTask_Click(object sender, EventArgs e) {
            System.Windows.Forms.ListView listViewOfCurrentTab = tabControl1.SelectedTab.Controls[0] as System.Windows.Forms.ListView;
            if (listViewOfCurrentTab.SelectedItems.Count > 0) {
                ListViewItem selectedItem = listViewOfCurrentTab.SelectedItems[0];
                Task taskToRemove = Tasks.FirstOrDefault(task => task.TaskName == selectedItem.Text);
                if (taskToRemove != null)
                    Tasks.Remove(taskToRemove);
                listViewOfCurrentTab.Items.Remove(selectedItem);
            }
        }

        private void btnManageCategories_Click(object sender, EventArgs e) {
            frmManageCategories FrmManageCategories = new frmManageCategories(Categories);
            FrmManageCategories.ShowDialog();
            Categories = FrmManageCategories.Categories;
            CreateCategoryTabs();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            TabPage selectedTab = tabControl1.SelectedTab;
            if (selectedTab != null) {
                System.Windows.Forms.ListView listViewOfCurrentTab = selectedTab.Controls[0] as System.Windows.Forms.ListView;
                listViewOfCurrentTab.Items.Clear();

                if (selectedTab.Text != tabControl1.TabPages[0].Text) {
                    List<Task> tasksByCategory = Tasks.Where(task => task.Category == selectedTab.Text).ToList();
                    LoadTasksIntoListView(listViewOfCurrentTab, tasksByCategory);
                    cbFilter.Enabled = false;
                }else {
                    cbFilter.Enabled = true;
                    if (cbFilter.SelectedItem == cbFilter.Items[0])
                        LoadTasksIntoListView(listViewOfCurrentTab, Tasks);
                    else
                        cbFilter.SelectedItem = cbFilter.Items[0];
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
            HandleFilter();
        }

        private void txtTaskName_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text)){
                //e.Cancel = true;
                txtTaskName.Focus();
                errorProvider1.SetError(txtTaskName, "Task Name is required!");
            }else {
                //e.Cancel = false;
                errorProvider1.SetError(txtTaskName, "");
            }
        }

        private void frmToDoList_FormClosing(object sender, FormClosingEventArgs e) {
            this.Dispose();
        }
    }
}
