using System;
using System.Windows.Forms;

namespace DelegatesDefined
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer[] Customers;
        private Address[] addresses;
        private delegate  void CustomerSorter(Customer[] customers);     //define delegate
        private delegate string MessageMethod();                         //define delegate

        private delegate void AddressSorter(Address[] addresses);       //define delegate

        private string DayOfWeekMessage()                               //method with delegate signature
        {
            return $"Today is {DateTime.Now.DayOfWeek}";
        }

        private void SortByAddress(Address[] addresses)
        {
            MessageBox.Show("Sort By Address");
        }

        private void SortByName(Customer[] customers)
        {
            MessageBox.Show("SortByName");
        }

        private void SortByBalance(Customer[] customers)
        {
            MessageBox.Show("SortByBalance");
        }

        private void SortByAccountNumber(Customer[] customers)
        {
            MessageBox.Show("SortByAccountNumber");
        }

        private void SortByRadioButton_Click(object sender, EventArgs e)
        {
            CustomerSorter sorter = null;

            if (sender == rdName)
            {
                sorter = SortByName;
            } else if (sender == rdBalance)
            {
                sorter = SortByBalance;
            }
            else
            {
                sorter = SortByAccountNumber;
            }

            sorter(Customers);
        }

        private void SortByAddressesRadioButton_Click(object sender, EventArgs e)
        {
            AddressSorter addSort = SortByAddress;
            addSort(addresses);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
//            MessageMethod myMethod = DayOfWeekMessage;                //assign delegate variable to method
//            MessageBox.Show(myMethod());
        }
    }
}
