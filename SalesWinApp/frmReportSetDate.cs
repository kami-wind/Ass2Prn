namespace SalesWinApp;


public partial class frmReportSetDate : Form
{
    public frmReportSetDate()
    {
        InitializeComponent();
    }

    private void frmReportSetDate_Load(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        SelectedStartDate = dtpStartDate.Value;
        SelectedEndDate = dtpEndDate.Value;
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    public DateTime SelectedStartDate { get; private set; }
    public DateTime SelectedEndDate { get; private set; }
}
