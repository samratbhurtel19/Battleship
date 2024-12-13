using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }
        private void LoadMembers()
        {
            try
            {
                DataTable membersTable = Member.GetAllMembers();
                dgvMembers.DataSource = membersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMembers_Click(object sender, EventArgs e)
        {
            // Validate Name
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    throw new Exception("Name is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Email
            try
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    throw new Exception("A valid email is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Phone Number
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumber.Text, @"^\d{3}-\d{3}-\d{4}$"))
                {
                    throw new Exception("A valid phone number in the format XXX-XXX-XXXX is required.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Membership Date
            DateTime membershipDate;
            try
            {
                membershipDate = dtpMembership.Value;
                if (membershipDate > DateTime.Now)
                {
                    throw new Exception("Membership Date cannot be in the future.");
                }

                if (membershipDate < new DateTime(1900, 1, 1))
                {
                    throw new Exception("Membership Date is too far in the past.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the Member
            try
            {
                Member member = new Member
                {
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    MembershipDate = membershipDate
                };

                member.AddMember();
                MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a member is selected in the DataGridView
                if (dgvMembers.CurrentRow == null || dgvMembers.CurrentRow.Cells["Name"] == null)
                {
                    MessageBox.Show("Please select a member to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedMemberName = dgvMembers.CurrentRow.Cells["Name"].Value.ToString();

                // Confirm deletion
                var confirmResult = MessageBox.Show($"Are you sure you want to delete member '{selectedMemberName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return;
                }

                // Delete the selected member from the database
                Member.DeleteMemberByName(selectedMemberName);

                // Notify the user
                MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView
                LoadMembers();
            }
            catch (Exception ex)
            {
                // Handle exceptions and display error messages
                MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefreshMembers_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void btnExittoDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }
        private void ClearInputs()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            dtpMembership.Value = DateTime.Now;
        }
    }
}
