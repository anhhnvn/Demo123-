using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BillWater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lsDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                dbfhf.Text = "1";
            }

            lsDanhSach.View = View.Details;
            lsDanhSach.GridLines = true;
            lsDanhSach.FullRowSelect = true;

            //tạo ra các cột cho listView
            lsDanhSach.Columns.Add("ID", 50);
            lsDanhSach.Columns.Add("Name", 150);
            lsDanhSach.Columns.Add("Phone", 100);
            lsDanhSach.Columns.Add("Type of cutomer", 200);
            lsDanhSach.Columns.Add("Number of member", 80);
            lsDanhSach.Columns.Add("Water last month(m3)", 80);
            lsDanhSach.Columns.Add("Water this moth(m3)", 80);
            lsDanhSach.Columns.Add("Water user", 80);
            lsDanhSach.Columns.Add("Total price (with Tax)", 80);
            lsDanhSach.Columns.Add("Description", 200);
            //Tạo ra một đối tượng có kiểu ListViewItem
            ListViewItem std_1 = new ListViewItem();
            std_1.Text = "1";
            std_1.SubItems.Add("Anderson");
            std_1.SubItems.Add("014399999");
            std_1.SubItems.Add("Household customer");
            std_1.SubItems.Add("1");
            std_1.SubItems.Add("1");
            std_1.SubItems.Add("1");
            std_1.SubItems.Add("1");
            std_1.SubItems.Add("1");
            std_1.SubItems.Add("1");
            lsDanhSach.Items.Add(std_1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Name = txtName.Text;
            string Phone = txtPhone.Text;
            string Type = null;
            if (cbType.SelectedIndex == 0)
            {
                Type = "Household customer";
            }
            else if (cbType.SelectedIndex == 1)
            {
                Type = "Administrative agency";
            }
            else if (cbType.SelectedIndex == 2)
            {
                Type = "Production units";
            }
            else if (cbType.SelectedIndex == 3)
            {
                Type = "Business services";
            }
              string Member = txtMember.Text;
            string Lmoth=txtLmoth.Text;
            string Tmoth=txtTmonth.Text;
            string UserSd=txtUserSd.Text;
            string Tong=txtTongTien.Text;

            string Description = textBox1.Text;
            ListViewItem item = new ListViewItem();
            item.Text = ID;
            item.SubItems.Add(Name);
            item.SubItems.Add(Phone);
            item.SubItems.Add(Type);
            item.SubItems.Add(Member);
            item.SubItems.Add(Lmoth);
            item.SubItems.Add(Tmoth);
            item.SubItems.Add(UserSd);
            item.SubItems.Add(Tong);
            item.SubItems.Add(Description);
            lsDanhSach.Items.Add(item);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbType.SelectedIndex == 0)
            {
                if (txtTmonth.Text == "" || txtLmoth.Text == "")
                {
                    MessageBox.Show("Enter Last moth and This moth in full");
                }
                else
                {
                    float Lmoth = float.Parse(txtLmoth.Text);
                    float Tmoth = float.Parse(txtTmonth.Text);
                    if ((Tmoth - Lmoth) <= 10)
                    {
                        float Uer = Tmoth - Lmoth;
                        txtMember.Text = "5.973";
                        txtUserSd.Text = Uer.ToString();
                        txtTongTien.Text = (float.Parse(txtMember.Text) * float.Parse(txtUserSd.Text) * 0.1).ToString("F2");
                    }
                    else if ((Tmoth - Lmoth) <= 20)
                    {
                        float Uer = Tmoth - Lmoth;
                        txtMember.Text = "7.052";
                        txtUserSd.Text = Uer.ToString();
                        txtTongTien.Text = (float.Parse(txtMember.Text) * float.Parse(txtUserSd.Text) * 0.1).ToString("F2");
                    }
                    else if ((Tmoth - Lmoth) <= 30)
                    {
                        float Uer = Tmoth - Lmoth;
                        txtMember.Text = "8.699";
                        txtUserSd.Text = Uer.ToString();
                        txtTongTien.Text = (float.Parse(txtMember.Text) * float.Parse(txtUserSd.Text) * 0.1).ToString("F2");
                    }
                    else
                if ((Tmoth - Lmoth) < 0)
                    {
                        MessageBox.Show("Required to enter This month as greater than Last month");
                        txtTmonth.Focus();
                        txtLmoth.Focus();
                    }
                    else
                    {
                        float Uer = Tmoth - Lmoth;
                        txtMember.Text = " 15.929";
                        txtUserSd.Text = Uer.ToString();
                        txtTongTien.Text = (float.Parse(txtMember.Text) * float.Parse(txtUserSd.Text) * 0.1).ToString("F2");
                    }
                }
            }
            else if (cbType.SelectedIndex == 1)
            {
                if (txtTmonth.Text == "" || txtLmoth.Text == "")
                {
                    MessageBox.Show("Enter Last moth and This moth in full");
                }
                else
                {
                    float Lmoth = float.Parse(txtLmoth.Text);
                    float Tmoth = float.Parse(txtTmonth.Text);
                    if ((Tmoth - Lmoth) > 0)
                    {
                        float Uer = Tmoth - Lmoth;
                        txtMember.Text = " 9.955";
                        txtUserSd.Text = Uer.ToString();
                        txtTongTien.Text = (float.Parse(txtMember.Text) * float.Parse(txtUserSd.Text) * 0.1).ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Required to enter This month as greater than Last month");
                    }    
                }
            }
            else if (cbType.SelectedIndex == 2)
            {
                if (txtTmonth.Text == "" || txtLmoth.Text == "")
                {
                    MessageBox.Show("Enter Last moth and This moth in full");
                }
                else
                {
                    float Lmoth = float.Parse(txtLmoth.Text);
                    float Tmoth = float.Parse(txtTmonth.Text);
                    if ((Tmoth - Lmoth) > 0)
                    {
                        float Uer = Tmoth - Lmoth;
                        txtMember.Text = " 11.615";
                        txtUserSd.Text = Uer.ToString();
                        txtTongTien.Text = (float.Parse(txtMember.Text) * float.Parse(txtUserSd.Text) * 0.1).ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Required to enter This month as greater than Last month");
                    }
                }
            }
            else if (cbType.SelectedIndex == 3)
            {
                if (txtTmonth.Text == "" || txtLmoth.Text == "")
                {
                    MessageBox.Show("Enter Last moth and This moth in full");
                }
                else
                {
                    float Lmoth = float.Parse(txtLmoth.Text);
                    float Tmoth = float.Parse(txtTmonth.Text);
                    if ((Tmoth - Lmoth) > 0)
                    {
                        float Uer = Tmoth - Lmoth;
                        txtMember.Text = " 22.608";
                        txtUserSd.Text = Uer.ToString();
                        txtTongTien.Text = (float.Parse(txtMember.Text) * float.Parse(txtUserSd.Text) * 0.1).ToString("F2" );
                    }
                    else
                    {
                        MessageBox.Show("Required to enter This month as greater than Last month ");
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = " ";
            txtLmoth.Text = " ";
            txtID.Text = " ";
            txtMember.Text = " ";
            txtUserSd.Text = " ";
            txtName.Text = "  ";
            txtPhone.Text = " ";
            txtTmonth.Text = "";
        }

    }
    }

