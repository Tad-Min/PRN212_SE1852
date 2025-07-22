using BusinessObjects_EF_IO;
using Services_EF_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.IO;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace WpfApp_EF_IO
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            RestoreLoginInformation();
        }

        private void RestoreLoginInformation()
        {
            string log_file = "login_log.txt";
            if (File.Exists(log_file))
            {//nếu có tồn tại file này:
                StreamReader sr = new StreamReader(log_file);
                string line = sr.ReadLine();
                sr.Close();
                //tách line thành 3 thông tin: email; password; save
                string[] arrData = line.Split(';');
                if(arrData.Length==3 && arrData[2]=="True")
                {
                    txtEmail.Text = arrData[0];
                    txtPassword.Password=arrData[1];
                    chkSaveInfor.IsChecked = true;
                }    
            }
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string email=txtEmail.Text;
                string pwd = txtPassword.Password;
                IAccountMemberService ams=new  AccountMemberService();
                AccountMember am=ams.Login(email, pwd);
                if(am==null)
                {
                    MessageBox.Show(
                        "Đăng nhập thất bại, vui lòng kiểm tra lại thông tin đăng nhập",
                        "Đăng nhập thất bại",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    Close();

                    SaveLoginInformation(am, chkSaveInfor.IsChecked.Value);
                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Lỗi đăng nhập:" + ex.Message,
                    "Lỗi đăng nhập",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
        void SaveLoginInformation(AccountMember am,bool saved)
        {
            string infor = am.EmailAddress + ";" + am.MemberPassword + ";" + saved;
            StreamWriter sw = new StreamWriter("login_log.txt",false,Encoding.UTF8);
            sw.WriteLine(infor);
            sw.Close();
        }
    }
}
