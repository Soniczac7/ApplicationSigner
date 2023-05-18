using System.Diagnostics;

namespace Application_Signer
{
    public partial class Form1 : Form
    {
        bool canClose = true;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(451, 289);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openExe.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openExe.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openPFX.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openPFX.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !textBox3.UseSystemPasswordChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(787, 289);

            if (textBox3.UseSystemPasswordChar == false)
            {
                textBox3.UseSystemPasswordChar = true;
            }

            // Check windows kits exists
            if (Directory.Exists(@"C:\Program Files (x86)\Windows Kits") == false)
            {
                MessageBox.Show("Windows SDK does not exist.\nDownload and install the Windows SDK.\nhttps://developer.microsoft.com/en-us/windows/downloads/windows-sdk/", "Code Signing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check executable exists
            if (File.Exists(textBox1.Text) == false)
            {
                MessageBox.Show("Executable does not exist at:\n" + textBox1.Text, "Code Signing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check PFX file exists
            if (File.Exists(textBox2.Text) == false)
            {
                MessageBox.Show("PFX file does not exist at:\n" + textBox2.Text, "Code Signing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if timestamp server is a url if enabled
            if (checkBox1.Checked && textBox5.Text == "")
            {
                MessageBox.Show("The timestamping url field is not filled in when \"Use Timestamping\" is checked.\nUncheck \"Use Timestamping\" or enter a timestamping server URL.", "Code Signing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var list = Directory.GetFiles(@"C:\Program Files (x86)\Windows Kits\10\bin\", "signtool.exe", SearchOption.AllDirectories);

            // Check signtool.exe exists
            if (list[0] == null)
            {
                MessageBox.Show("Windows SDK is missing components.\nReinstall the windows SDK.\nhttps://developer.microsoft.com/en-us/windows/downloads/windows-sdk/" + textBox2.Text, "Code Signing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            button1.Enabled = false;
            canClose = false;

            list[0] = list[0].Replace("Program Files (x86)", "\"Program Files (x86)\"");
            list[0] = list[0].Replace("Windows Kits", "\"Windows Kits\"");

            if (checkBox1.Checked)
            {
                Log("Signing with timestamp server: " + textBox5.Text);
            }

            Log(String.Format("Executing command: cmd.exe /c {0} sign /fd SHA256 /f \"{1}\" /p \"{2}\" \"{3}\"", list[0].Remove(list[0].Length - 16) + @"x64\signtool.exe", textBox2.Text, textBox3.Text, textBox1.Text));

            Thread thread = new Thread(new ThreadStart(new MethodInvoker(delegate ()
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = false;
                info.RedirectStandardOutput = true;
                info.RedirectStandardError = true;
                info.ErrorDialog = true;
                info.FileName = "cmd.exe";
                if (!checkBox1.Checked)
                {
                    info.Arguments = String.Format("/c {0} sign /fd SHA256 /f \"{1}\" /p \"{2}\" \"{3}\"", list[0].Remove(list[0].Length - 16) + @"x64\signtool.exe", textBox2.Text, textBox3.Text, textBox1.Text);
                }
                else
                {
                    info.Arguments = String.Format("/c {0} sign /tr {4} /td SHA256 /fd SHA256 /f \"{1}\" /p \"{2}\" \"{3}\"", list[0].Remove(list[0].Length - 16) + @"x64\signtool.exe", textBox2.Text, textBox3.Text, textBox1.Text, textBox5.Text);
                }
                Process process = new Process();
                process.StartInfo = info;
                process.OutputDataReceived += process_OnDataReceived;
                process.ErrorDataReceived += process_OnDataReceived;
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                canClose = true;

                this.Invoke(new MethodInvoker(delegate ()
                {
                    button1.Enabled = true;
                }));
            })));
            thread.Start();
        }

        private void process_OnDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == "" || e.Data == " " || e.Data == null) { return; }
            Log(e.Data);
        }

        public void Log(string text)
        {
            if (textBox4.InvokeRequired)
            {
                Action action = () => textBox4.AppendText(text + Environment.NewLine);
                this.Invoke(action);
            }
            else
            {
                textBox4.AppendText(text + Environment.NewLine);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClose == false)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}