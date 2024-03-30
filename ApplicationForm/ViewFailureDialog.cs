using ClassLibrary;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace ApplicationForm;

public partial class ViewFailureDialog : Form
{
    public ViewFailureDialog()
    {
        InitializeComponent();
    }

    public ViewSchema View
    {
        get { return _view; }
        set
        {
            _view = value;
            this.Text = "SQL Error: "+_view.ViewName;
            txtSQL.Text = _view.ViewSQL;
        }
    }

    public string ViewSQL
    {
        get { return txtSQL.Text; }
    }


    private void btnOK_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }

    private ViewSchema _view;
}