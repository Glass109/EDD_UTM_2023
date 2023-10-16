namespace Actividad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void randomFillButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                listView1.Items.Add(rnd.Next(1000).ToString());
            }
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if ((int.Parse(item.Text) % 2) == 0)
                {
                    listView1.Items.Remove(item);
                    listView2.Items.Add(item);
                }
                else
                {
                    listView1.Items.Remove(item);
                    listView3.Items.Add(item);
                }
            }
            
        }
    }
}