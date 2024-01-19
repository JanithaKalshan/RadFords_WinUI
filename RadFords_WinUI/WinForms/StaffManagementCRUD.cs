using Microsoft.IdentityModel.Tokens;
using RadFordDataAccessLayer.Models;
using RadFordsBusinessLayer.Controller;
using RadFordsBusinessLayer.Dtos;
using RadFordsBusinessLayer.InterfacesBL;
using RadFordsWinUI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RadFordsWinUI.WinForms
{
    public partial class StaffManagementCRUD : Form
    {

        #region >> Properties
        IStaffMemberController _staffMemberController;
        bool flag = false;
        string? message;
        List<StaffMemberGetDto>? globalList;
        int currentItemIndex = 0;
        #endregion

        #region >> Constructor
        public StaffManagementCRUD()
        {
            InitializeComponent();
            _staffMemberController = new StaffMemberController();
        }

        #endregion

        #region >> Events
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StaffManagementCRUD_Load(object sender, EventArgs e)
        {
            //Form combo boxes load
            List<StaffMemberGetDto>? list = null;
            cmbStaffType.DataSource = Enum.GetValues(typeof(StaffType));
            cmbTitle.DataSource = Enum.GetValues(typeof(Title));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));

            (flag, message, list) = _staffMemberController.GetStaffMembersByType(StaffType.Manager.ToString());
            cmbManager.DataSource = list;
            cmbManager.DisplayMember = "FullName";
            cmbManager.ValueMember = "StaffMemberId";

            //Set defaut value for PageSize
            cmbPageSize.SelectedItem = "10";

            GeneratePageNumbers();

            //filter status combo box load
            var statusList = Enum.GetValues(typeof(Status))
                                         .Cast<Status>()
                                         .Select(e => e.ToString())
                                         .ToList();
            statusList.Insert(0, "All");
            cmbFilterStatus.DataSource = statusList;
            cmbFilterStatus.SelectedItem = "Active";

           

            loadGridData(Status.Active.ToString());

        }

        private void cmbStaffType_SelectedIndexChange(object sender, EventArgs e)
        {
            if (cmbStaffType.SelectedValue?.ToString() == StaffType.Manager.ToString())
            {
                lblManager.Hide();
                cmbManager.Hide();
            }
            else
            {
               
                lblManager.Show();
                cmbManager.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var dto = new StaffMemberUpdateDto
            {
                StaffMemberId = lblId.Text == ""?0 : Convert.ToInt32(lblId.Text),
                StaffType = cmbStaffType.Text,
                Title = cmbTitle.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                MiddleInitial = txtMiddleName.Text,
                HomePhone = txtHomePhone.Text,
                CellPhone = txtCellPhone.Text,
                OfficeExtension = txtOfficeExtension.Text,
                IRDNumber = txtIRDTaxNumber.Text,
                Status = cmbStatus.Text,
                ManagerId = cmbStaffType.Text == StaffType.Manager.ToString()? null : (int)cmbManager.SelectedValue
            };
            if (Validate())
            {
                (flag, message) = _staffMemberController.AddUpdateStaffMember(dto);
                showErrorMessage(flag, message);
                loadGridData(Status.Active.ToString());
                ClearFields();
            }
        }

        private void dgvStaffMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStaffMember.Rows.Count)
            {
                DataGridViewRow row = dgvStaffMember.Rows[e.RowIndex];

                lblId.Text = row.Cells["dgvId"].Value.ToString();
                txtFirstName.Text = row.Cells["dgvFirstName"].Value.ToString();
                txtLastName.Text = row.Cells["dgvLastName"].Value.ToString();
                txtMiddleName.Text = row.Cells["dgvMiddleInitails"].Value.ToString();
                txtHomePhone.Text = row.Cells["dgvHomePhone"].Value.ToString();
                txtCellPhone.Text = row.Cells["dgvCellPhone"].Value.ToString();
                txtOfficeExtension.Text = row.Cells["dgvOfficeExtention"].Value.ToString();
                txtIRDTaxNumber.Text = row.Cells["dgvIRDNumber"].Value.ToString();

                if (Enum.TryParse(row.Cells["dgvStatus"].Value.ToString(), out Status statusEnum))
                {
                    cmbStatus.SelectedItem = statusEnum;
                }

                if (Enum.TryParse(row.Cells["dgvStaffType"].Value.ToString(), out StaffType stafftypeEnum))
                {
                    cmbStaffType.SelectedItem = stafftypeEnum;
                }

                if (row.Cells["dgvStaffType"].Value.ToString() == StaffType.Employee.ToString())
                {
                    if (row.Cells["dgvManagerId"].Value != null)
                    {
                        cmbManager.SelectedValue = row.Cells["dgvManagerId"].Value;
                    }
                    cmbManager.Show();
                }

                btnDelete.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!lblId.Text.IsNullOrEmpty())
            {
                DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    (flag, message) = _staffMemberController.DeleteStaffMember(Convert.ToInt32(lblId.Text));
                    ClearFields();
                    showErrorMessage(flag, message);
                    loadGridData(Status.Active.ToString());
                } 
            }
            else
            {
                showErrorMessage(false, "Somthing happen! Please tryagin.");
            }
        }


        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGridData(cmbFilterStatus.Text);
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            GeneratePageNumbers();
            loadGridData(cmbFilterStatus.Text);
        }

        private void cmbPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGridData(cmbFilterStatus.Text);
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            var data = globalList?
                        .GroupBy(dto => dto.StaffType)
                        .OrderBy(group => group.Key) 
                        .SelectMany(group => group.OrderBy(dto => dto.FirstName));

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToCsvFile(data, sfd.FileName);
                    MessageBox.Show("Data Successfully Imported");
                }
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var data = globalList
                        .GroupBy(dto => dto.StaffType)
                        .OrderBy(group => group.Key)
                        .SelectMany(group => group.OrderBy(dto => dto.FirstName)).ToList();

            float yPos = 10f; 
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            using (var printFont = new Font("Arial", 10))
            {
                while (currentItemIndex < globalList.Count)
                {
                    var item = data[currentItemIndex];
                    string textToPrint = $"{item.StaffMemberId} - {item.StaffType} - {item.Title} - {item.FirstName} {item.LastName} - {item.MiddleInitial} {item.HomePhone} - {item.CellPhone}- {item.OfficeExtension} - {item.IRDNumber} - {item.Status} - {item.ManagerId}";
                    SizeF stringSize = e.Graphics.MeasureString(textToPrint, printFont);
                    yPos += stringSize.Height;

                    if (yPos + stringSize.Height > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        break;
                    }

                    e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, leftMargin, yPos);
                    currentItemIndex++;
                }
            }

            if (currentItemIndex >= globalList.Count)
                e.HasMorePages = false; 
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                currentItemIndex = 0; 
                printDocument.Print();
                MessageBox.Show("Data Successfully Printed");
            }
        }

        private void txtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true; 
            }
        }

        private void txtCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtOfficeExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region >> Local Methods

        private void ClearFields()
        {
            cmbStaffType.DataSource = Enum.GetValues(typeof(StaffType));
            cmbTitle.DataSource = Enum.GetValues(typeof(Title));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtCellPhone.Clear();
            txtHomePhone.Clear();
            txtOfficeExtension.Clear();
            txtIRDTaxNumber.Clear();
            btnDelete.Hide();
        }

        private void showErrorMessage(bool flag, string message)
        {
            if (!flag)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadGridData(string status)
        {
            int pageSize = Convert.ToInt32(cmbPageSize.Text);
            int pageNo = Convert.ToInt32(cmbPageNo.Text);
            (flag, message, globalList) = _staffMemberController.GetStaffMembersWithPagination(pageSize,pageNo);
            if (status != "All")
            {
                dgvStaffMember.DataSource = globalList?.Where(x => x.Status == status).ToList();
            }
            else
            {
                dgvStaffMember.DataSource = globalList?.ToList();
            }
        }

        private void GeneratePageNumbers()
        {
            List<int> pageNumbers = new List<int>();
            var totalRecordCount = _staffMemberController.GetRecordCount();
            var pageSize = Convert.ToInt32(cmbPageSize.Text);
            var totalPageCount = (int)Math.Ceiling((double)totalRecordCount / pageSize);
            for(int i=1; i<=totalPageCount; i++)
            {
                pageNumbers.Add(i);
            }
            cmbPageNo.DataSource = pageNumbers;
            cmbPageNo.SelectedItem = "1";
        }

        private void ExportToCsvFile(IEnumerable<dynamic> data, string fileName)
        {
            StringBuilder csvContent = new StringBuilder();
            string[] columnNames = new string[] { "StaffMemberId","StaffType", "Title","FirstName","LastName","MiddleInitials","HomePhone","CellPhone","OfficeExtention","IRDNumber","Status","ManagerId" };
            csvContent.AppendLine(string.Join(",", columnNames));

            foreach (var row in data)
            {
                string[] cells = new string[] { Convert.ToString(row.StaffMemberId), row.StaffType, row.Title, row.FirstName, row.LastName, row.MiddleInitial, row.HomePhone, row.CellPhone, row.OfficeExtension, row.IRDNumber, row.Status, Convert.ToString(row.ManagerId)};
                csvContent.AppendLine(string.Join(",", cells.Select(cell => $"\"{cell}\""))); 
            }
            File.WriteAllText(fileName, csvContent.ToString());
          
        }

        private bool Validate()
        {
            if (txtFirstName.Text.IsNullOrEmpty())
            {
                showErrorMessage(false, "Please fill all the fields that are marked with asterisk.");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

    }
}
