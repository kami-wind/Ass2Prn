using BusinessObject;
using DataAccess.Repository;
using System.Diagnostics.Metrics;

namespace SalesWinApp;

public partial class frmMemberDialog : Form
{

    public bool InsertOrUpdate { get; set; }

    public MemberObject MemberInfo { get; set; }

    public IMemberRepository MemberRepository { get; set; }

    public frmMemberDialog()
    {
        InitializeComponent();
    }


    private void btnSave_Click(object sender, EventArgs e)
    {

        try
        {
            var member = new MemberObject
            {
                MemberID = int.Parse(txtMemberID.Text),
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text


            };

            if (InsertOrUpdate == false)
            {
                MemberRepository.InsertMember(member);
            }
            else
            {
                // Update the MemberInfo object with the new values
                MemberInfo.Email = member.Email;
                MemberInfo.CompanyName = member.CompanyName;
                MemberInfo.City = member.City;
                MemberInfo.Country = member.Country;
                MemberInfo.Password = member.Password;

                MemberRepository.UpdateMember(member);
            }
            MessageBox.Show(InsertOrUpdate == false ? "Member added successfully!" : "Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Member" : "Update Member");
        }
    }


    //private bool ValidateForm()
    //{
    //    // Perform validation on the form fields
    //    if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
    //    {
    //        MessageBox.Show("Please enter a valid company name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        return false;
    //    }

    //    if (string.IsNullOrWhiteSpace(txtEmail.Text))
    //    {
    //        MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        return false;
    //    }

    //    if (string.IsNullOrWhiteSpace(txtPassword.Text))
    //    {
    //        MessageBox.Show("Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        return false;
    //    }

    //    if (string.IsNullOrWhiteSpace(txtCity.Text))
    //    {
    //        MessageBox.Show("Please enter a valid city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        return false;
    //    }

    //    if (string.IsNullOrWhiteSpace(txtCountry.Text))
    //    {
    //        MessageBox.Show("Please enter a valid country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        return false;
    //    }

    //    return true;
    //}

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void frmMemberDialog_Load(object sender, EventArgs e)
    {
        txtMemberID.Enabled = !InsertOrUpdate;
        if (InsertOrUpdate == true)
        {
            txtMemberID.Text = MemberInfo.MemberID.ToString();
            txtEmail.Text = MemberInfo.Email;
            txtCompanyName.Text = MemberInfo.CompanyName;
            txtCity.Text = MemberInfo.City;
            txtCountry.Text = MemberInfo.Country;
            txtPassword.Text = MemberInfo.Password;
        }
    }
}
