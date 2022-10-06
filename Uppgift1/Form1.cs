namespace Uppgift1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = @"C:\user\Uppgift1";
        public void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{txtName.Text},{txtAdress.Text},{txtPostnr.Text}," +
                    $"{txtPostort.Text},{txtPhone.Text},{txtEmail.Text}");

                sw.Close();
            }
        }
        public void btnShow_Click(object sender, EventArgs e)
        {
            string row;
            
            using (StreamReader sr = new StreamReader(path))
                while (!sr.EndOfStream)
                {
                    AdressList.Items.Add(sr.ReadLine());
                }

            txtName.Clear(); txtName.Focus();
            txtAdress.Clear();
            txtPostnr.Clear();
            txtPostort.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        public void btnChange_Click(object sender, EventArgs e)
        {
            string OldUser = AdressList.SelectedItem.ToString();
            string NewUser = txtName.Text + ',' + txtAdress.Text + ',' + txtPostnr.Text +
                ',' + txtPostort.Text + ',' + txtPhone.Text + ',' + txtEmail.Text;
            string data = File.ReadAllText(path);
            string value = data.Replace(OldUser, NewUser);
            
            File.WriteAllText(path, value);
        }

        public void btnDelate_Click(object sender, EventArgs e)
        {
            AdressList.Items.Remove(AdressList.SelectedItem);
        }

        public void btnDelateAll_Click(object sender, EventArgs e)
        {
            AdressList.DataSource = null;
            AdressList.Items.Clear();

            File.Create(path).Close();
        }

        public void btnSearchShow_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            string[] filen = File.ReadAllLines(path);

            foreach (string text in filen)
            {
                if (text.ToLower().Contains(search.ToLower()))
                {
                    AdressList.Items.Add(text);
                }
            }
        }

        public void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear(); txtAdress.Clear(); txtPostnr.Clear();
            txtPostort.Clear();txtPhone.Clear();txtEmail.Clear();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] selected = AdressList.SelectedItem.ToString().Split(',');

            txtName.Text = selected[0];
            txtAdress.Text = selected[1];
            txtPostnr.Text = selected[2];
            txtPostort.Text = selected[3];
            txtPhone.Text = selected[4];
            txtEmail.Text = selected[5];
        }
    }
}