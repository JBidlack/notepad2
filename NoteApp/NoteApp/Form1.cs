using System.Data;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Title", typeof(string));
            dataTable.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 183;

        }

        private void button_New1(object sender, EventArgs e)
        {
            textTitle1.Clear();
            textMessage1.Clear();
        }

        private void button_Save1(object sender, EventArgs e)
        {
            dataTable.Rows.Add(textTitle1.Text, textMessage1.Text);

            textTitle1.Clear();
            textMessage1.Clear();
        }

        private void button_Open(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                if (index > -1)
                {
                    textTitle1.Text = dataTable.Rows[index].ItemArray[0].ToString();
                    textMessage1.Text = dataTable.Rows[index].ItemArray[1].ToString();
                }
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
            }
        }

        private void openFile(object sender, System.EventArgs e)
        {
            if (!fileOpened)
            {
                folderBrowserDialog1 = new FolderBrowserDialog();

                folderBrowserDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;

                DialogResult result = folderBrowserDialog1.ShowDialog();

                if(result == DialogResult.OK)
                {
                    fileName = textTitle1.Text + ".txt";
                    if (!File.Exists(fileName))
                    {
                        content = textMessage1.Text;
                        using (StreamWriter sw = new StreamWriter(fileName))
                        {
                            sw.Write(content);
                            sw.Close();
                        }
                    }
                    else
                    {
                     MessageBoxButtons verify = MessageBoxButtons.OKCancel;
                     DialogResult results = MessageBox.Show("This file already exists. Overwrite?", "Overwrite?", verify);

                        if (results == DialogResult.OK)
                        {
                            content = textMessage1.Text;
                            File.WriteAllText(folderBrowserDialog1.SelectedPath+"\\"+fileName, content);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}