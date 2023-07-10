using BusinessObject;
using DataAccess.Repository;
using System.Diagnostics.Metrics;

namespace SalesWinApp;

public partial class frmMember : Form
{
    public frmMember()
    {
        InitializeComponent();
    }

    private void txtMemberID_TextChanged(object sender, EventArgs e)
    {

    }

    IMemberRepository memberRepository = new MemberRepository();

    BindingSource source;

    private void frmMember_Load(object sender, EventArgs e)
    {
        btnDelete.Enabled = false;

        dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
        //   dgvMemberList.CellEndEdit += dgvMemberList_CellEndEdit;
    }

    private void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvMemberList.SelectedRows.Count > 0)
        {
            MemberObject selectedMember = dgvMemberList.SelectedRows[0].DataBoundItem as MemberObject;
            if (selectedMember != null)
            {
                txtMemberID.Text = selectedMember.MemberID.ToString();
                txtEmail.Text = selectedMember.Email;
                txtCompanyName.Text = selectedMember.CompanyName;
                txtCity.Text = selectedMember.City;
                txtCountry.Text = selectedMember.Country;
                txtPassword.Text = selectedMember.Password;
            }
        }
    }

    private void ClearText()
    {
        txtMemberID.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtCompanyName.Text = string.Empty;
        txtCity.Text = string.Empty;
        txtCountry.Text = string.Empty;
        txtPassword.Text = string.Empty;
    }


    private MemberObject? GetMemberObject()
    {
        MemberObject? member = null;
        try
        {
            member = new MemberObject
            {
                MemberID = int.Parse(txtMemberID.Text),
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text
            };
        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get Member");
        }
        return member;
    }

    public void LoadMemberList()
    {
        var members = memberRepository.GetMember();
        try
        {
            source = new BindingSource();
            source.DataSource = members;

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = source;
            if (members.Count() == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Load Member list");
        }
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        LoadMemberList();
    }

    private void btnClearText_Click(object sender, EventArgs e)
    {
        ClearText();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvMemberList.SelectedRows.Count > 0)
            {
                int memberID = (int)dgvMemberList.SelectedRows[0].Cells["MemberID"].Value;
                memberRepository.DeleteMember(memberID);
                LoadMemberList();
            }
            else
            {
                MessageBox.Show("Please select a member to delete.", "Delete Member");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Delete Member");
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmMemberDialog frmMemberDialog = new frmMemberDialog
        {
            Text = "Add Member",
            InsertOrUpdate = false,
            MemberRepository = memberRepository
        };

        if (frmMemberDialog.ShowDialog() == DialogResult.OK)
        {
            LoadMemberList();

            source.Position = source.Count - 1;
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        frmMain frm = new frmMain();
        frm.Show();
        this.Hide();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {

    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var members = memberRepository.GetMember();
        try
        {
            if (source == null) source = new();

            source.DataSource = members.Where(
                member => member.MemberID.ToString().Contains(txtMemberID.Text)
                && member.Email.Contains(txtEmail.Text)
                && member.CompanyName.Contains(txtCompanyName.Text)
                && member.City.Contains(txtCity.Text)
                && member.Country.Contains(txtCountry.Text)
                && member.Password.Contains(txtPassword.Text));

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = source;
            if (members == null)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Search Member list");
        }
    }

    private void dgvMemberList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) // Check if a valid row is clicked
        {
            DataGridViewRow selectedRow = dgvMemberList.Rows[e.RowIndex];

            // Retrieve the selected MemberObject from the DataBoundItem property of the selected row
            MemberObject selectedMember = selectedRow.DataBoundItem as MemberObject;

            // Create an instance of the frmMemberDialog form
            frmMemberDialog frmMemberDialog = new frmMemberDialog
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfo = selectedMember,
                MemberRepository = memberRepository
            };

            // Show the frmMemberDialog form as a dialog
            if (frmMemberDialog.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }
    }
}
