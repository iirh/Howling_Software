using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authed;
using Newtonsoft.Json;
using Jose.jwe;

namespace Howling_Software
{
    public partial class loader : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        Auth auth = new Auth();


        public loader()
        {
            InitializeComponent();
            bool authed = auth.Authenticate("YOUR SECRET CODE");
            if (authed != true)
            {
                Error.CstmError.Show("Please contact the Administration");
                Environment.Exit(0);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globals.username = user_box.Text;
            bool right = false;
            //  bool banned = auth.user.banned;
            // bool expired = auth.user.expired;

            string password = pw_box.Text;
            if (user_box.Text == "" || pw_box.Text == "")
            {
                Error.CstmError.Show("Username or Password empty!");
            }
            else
            {
                bool login = auth.Login(Globals.username, password);     //Login
                if (login == true)
                {
                    if (auth.user.banned == true)
                    {
                        Error.CstmError.Show("Your Account have been banned!");
                        auth.OnBannedUser += Auth_OnBannedUser;
                    }
                    else
                    {
                        right = true;
                    }
                    if (auth.user.expired == true)
                    {
                        Error.CstmError.Show("Account time expired!");
                        auth.OnInvalidUser += Auth_OnInvalidUser;
                    }
                    else
                    {
                        right = true;
                    }
                    if (right == true)
                    {
                        Error.CstmError.Show("Welcome " + Globals.username + " !");
                        Main loader = new Main();
                        this.Hide();
                        Globals.loggedoff = "false";
                        loader.Show();
                    }
                }
                else
                {
                    Error.CstmError.Show("Username or Password incorrect!");
                }
            }

        }

        private void Auth_OnInvalidUser(object sender, OnUserInvalidEvent e)
        {
            throw new NotImplementedException();
        }

        private void Auth_OnBannedUser(object sender, OnUserBannedEvent e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Globals.loggedoff == "true") lo_button.Visible = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
