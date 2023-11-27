using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using HttpClient httpClient = new HttpClient();



            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + richTextBox1.Text);


            var result = await httpClient.GetAsync("https://localhost:7219/api/Home/TestToken");


            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var message = await result.Content.ReadAsStringAsync();
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("hatalý token verdiniz");
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using HttpClient httpClient = new HttpClient();


            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + richTextBox1.Text);


            var result = await httpClient.GetAsync("https://localhost:7219/api/Account/GetProducts");


            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();


                var list = JsonSerializer.Deserialize<List<Product>>(content);

                list.ForEach(x =>
                {
                    listBox1.Items.Add($"name : {x.Name}  ýd: {x.Id}");
                });
            }
            else
            {
                MessageBox.Show("hatalý token ile giriþ denemesi!!");
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            LoginDto loginDto = new LoginDto();


            loginDto.email = textBox1.Text;
            loginDto.email = textBox2.Text;

            using HttpClient httpClient = new HttpClient();
            var jsonData =   JsonSerializer.Serialize(loginDto);

            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");


           var result = await  httpClient.PostAsync("https://localhost:7219/api/Account/Login", content);

            if (result.IsSuccessStatusCode)
            {
                MessageBox.Show("iþlem baþarýlý");
            richTextBox1.Text = "";
            richTextBox1.Text = await result.Content.ReadAsStringAsync();

            }
            else
            {
                MessageBox.Show("hatalý iþlem");
            }
          

        }
    }



    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class LoginDto
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}