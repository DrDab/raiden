using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Raiden
{
    public partial class ClientForm : Form
    {
        delegate void UpdateImpostorsCallback();

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Print("Initializing client.");
            DLLManager.Listen();
            DLLManager.SetProcess();
            Task.Factory.StartNew(() => DLLManager.StartDLLs());
            ColorList.SelectedIndex = 0;
            Print("Client initialized.");
        }

        delegate void PrintDelegate(string data);

        public void Print(string data)
        {
            if (this.OutputTextBox.IsDisposed)
            {
                return;
            }
            if (this.OutputTextBox.InvokeRequired)
            {
                if (this.IsDisposed)
                {
                    return;
                }
                PrintDelegate print_delegate = new PrintDelegate(Print);
                this.Invoke(print_delegate, new object[] { data });
            }
            else
            {
                OutputTextBox.Text += (data + "\r\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            DLLManager.Send("c " + ColorList.SelectedIndex.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void UpdateImpostorsText()
        {
            if (this.ImpostorsLabel.InvokeRequired)
            {
                UpdateImpostorsCallback del = new UpdateImpostorsCallback(UpdateImpostorsText);
                this.Invoke(del, new object[] { });
                return;
            }
            List<String> impostors = HackManager.impostors;
            if (impostors.Count == 0)
            {
                ImpostorsLabel.Text = "There are no impostors.";
            }
            else
            {
                ImpostorsLabel.Text = "Impostors: " + string.Join(", ",
                    impostors);

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CanMoveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CanMoveCheckBox.Checked)
            {
                DLLManager.Send("b");
            }
            else
            {
                DLLManager.Send("a");
            }
        }

        private void CooldownCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CooldownCheckBox.Checked)
            {
                DLLManager.Send("d");
            }
            else
            {
                DLLManager.Send("k");
            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        
    }
}
