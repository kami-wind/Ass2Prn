namespace SalesWinApp;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string password = txtPassword.Text;

        // Perform authentication by checking email and password
        bool isAuthenticated = AuthenticateUser(email, password);

        if (isAuthenticated)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private bool AuthenticateUser(string email, string password)
    {
        // Perform authentication logic here, such as checking against a database or predefined credentials
        // Return true if authentication is successful, false otherwise
        if (email == "admin@fstore.com" && password == "admin@@")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {

    }
}