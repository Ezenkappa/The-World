using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, friend;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void submitButton_Click(object sender, EventArgs e)
        {
            i = new Person(MyNameIP.Text, 0);
            friend = new Person(FriendNameIP.Text, 100000);

            MyNameIP.Enabled = false;
            FriendNameIP.Enabled = false;
            submitButton.Enabled = false;

            borrowButton.Text = "跟"+ friend.Name +"借1000元";
            repayButton.Text = "還" + friend.Name + "1000元";

            borrowButton.Enabled = true;
            repayButton.Enabled = true;

            MynameLable.Text = i.Name;
            FriendnameLable.Text = friend.Name;

        }
        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, 1000);
            updateMoney();
        }
        private void repayButton_Click(object sender, EventArgs e)
        {   
            i.repay(friend, 1000);
            updateMoney();
        }
        private void updateMoney()
        {   //""+int 會強制把int變成字串加進空字串""
            MyMoney.Text = ""+ i.Money;
            FriendMoney.Text = ""+ friend.Money;
            FriendMoney.Text = ""+ friend.Money;
        }
    }
}
