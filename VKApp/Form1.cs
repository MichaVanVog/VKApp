using System.Text.Json;

namespace VKApp
{
    public partial class Vkontakte : Form
    {
        private readonly HttpClient client;
        private string TOKEN { get; set; } = "653fcbec653fcbec653fcbec426544ed556653f653fcbec04c298fb47fe9bca0f777fbb";
        private string Version { get; set; } = "5.131";

        private Group _group;
        private Group group { get { return _group; }
        set { _group = value; AvatarPictureBox.Load(_group.photo_200); GroupNameLabel.Text = _group.name; }
        }

        public Vkontakte()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        public static string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);
            return JsonSerializer.Serialize(jsonElement, options);
        }

        public string GetUrl(String method, Dictionary<String, String> parameters)
        {
            var builder = new UriBuilder($"https://api.vk.com/method/{method}?");
            builder.Port = -1;

        }

        async void FetchUserInfo()
        {
            HttpResponseMessage response = await client.GetAsync($"https://api.vk.com/method/groups.getById?group_id={IdTextBox.Text}&access_token={TOKEN}&v={Version}");
            var content = await response.Content.ReadAsStringAsync();

            var vkResponse = JsonSerializer.Deserialize<Response<Group>>(content);
            this.group = vkResponse?.response?[0];
            ResponseRichTextBox.Text = group?.ToString();
        }

        private void MakeRequestButton_Click(object sender, EventArgs e)
        {
            FetchUserInfo();
        }
    }
}