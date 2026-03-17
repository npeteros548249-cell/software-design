namespace Task5_CustomDescendingOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class DescendingSorter
        {
            private int[] data = { 50, 10, 90, 20, 40, 30 };

            public int[] GetData() => data;

            public void SortDescending()
            {
                Array.Sort(data);
                Array.Reverse(data);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            DescendingSorter sorter = new DescendingSorter();
            sorter.SortDescending();
            int[] sortedData = sorter.GetData();
            listBoxResults.DataSource = sortedData;
        }
    }
}
